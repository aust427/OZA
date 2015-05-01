using UnityEngine;
using System.Collections;

/**
 * 
 * --- DamageableObject superclass ---
 * 
 * This sets the basic perameters behind damageable objects.
 * 
 * These parameters include:
 * - Health
 * - Armor
 * - Regeneration
 * - Healthbar
 * - ...And possibly more
 * 
 * - Health
 * ---- Variable maxHealth is assigned to variable health on start().
 * 		When the health value reaches 0, the DIE() method is called.
 * 		Health can be regenerated with a flat rate of the regeneration
 * 		value per second. This calls the heal() method every second, which
 * 		can also be used to heal the object for any amount. The object
 * 		cannot be healed past the maxHealth value.
 * 
 * - Armor
 * ---- Armor protets the object from all damage, but takes a hit in
 * 		armor durability. When the armor is depleted, the remaining damage
 * 		is carried over to the health value.
 * 
 * - Regeneration
 * ---- Regenerates the health of the object at a set rate per second.
 * 		Health cannot be regenerated if the object is dead, or if the health
 * 		value is already at the maximum.
 * 
 **/

public class DamageableObject : MonoBehaviour {

	public float maxHealth = 100f,
					health = 0f,
					maxArmor = 0f,
					armor = 0f,
					regeneration = 0f,
					iFrameDuration = 0f,
					iFrameTime = 0f;

	protected bool isDead = false,
				   hasHealthBar = true,
				   isDamageable = true,
				   inKnockback = false;

	private float knockbackTime = 0f;
	private float healthPercentage;

	// For the iframe animation
	SpriteRenderer sRenderer;

	// For the floating health bar
	//Transform parentTransform;
	public GameObject floatingHealthBar;
	GameObject fhb;

	// Getters and setters
	public float getMaxHealth() {return this.maxHealth;}
	public void setMaxHealth(float value) {this.maxHealth = value;}
	public float getHealth() {return this.health;}
	public void setHealth(float value) {
		if (value <= 0) {
			healthPercentage = 0f;
			updateHealthBar();
			die ();
		}
		else {
			if (value >= this.maxHealth)
				this.health = this.maxHealth;
			this.health = value;
		}
		healthPercentage = this.health / this.maxHealth;
		updateHealthBar ();
	}
	public float getMaxArmor() {return this.maxArmor;}
	public void setMaxArmor(float value) {this.maxArmor = value;}
	public float getArmor() {return this.armor;}
	public void setArmor(float value) {
		if (value >= this.maxArmor)
			this.armor = this.maxArmor;
		this.armor = value;
	}
	public float getRegeneration() {return this.regeneration;}
	public void setRegeneration(float value) {this.regeneration = value;}
	public float getIFrameDuration() {return this.iFrameDuration;}
	public void setIFrameDuration(float value) {this.iFrameDuration = value;}

	public bool getDamageable() {return this.isDamageable;}
	public void setDamageable(bool value) {this.isDamageable = value;}
	public bool getKnockback() {return this.inKnockback;} // Potentially worthless
	public bool getIsPlayer() {return this.tag == "Player";}

	public bool getHasHealthBar() {return this.hasHealthBar;}
	public void setHasHealthBar(bool value) {this.hasHealthBar = value;}

	// Manipulation methods

	/** 
	 * Heals the object for the set amount. If the end result of health
	 * is higher than the maxHealth value, the health is set to maxHealth.
	 * 
	 * @param	amount
	 * 		Points of health to heal
	 **/
	public void heal(float amount) {this.setHealth (this.health + amount);}

	/**
	 * Adds the specified amount of armor.
	 * 
	 * @param	amount
	 * 		Points of armor to add
	 **/
	public void addArmor(float amount) {this.setArmor (this.armor + amount);}

	/**
	 * Damages the object for the set amount. The setHealth() method checks
	 * if the health value goes below 0.
	 * 
	 * @param	amount
	 * 		Points of health to damage
	 **/
	public void damage(float amount) {
		if (this.isDamageable) {
			Debug.Log ("Damaged: " + amount);
			if (armor > 0)
				damageArmor (amount);
			else 
				this.setHealth (this.health - amount);
			if (this.iFrameDuration > 0)
				this.startIFrame();
		}
	}

	/**
	 * Damages the armor for the set amount. If there is not enough armor,
	 * the damage overflows to the health.
	 * 
	 * @param	amount
	 * 		Points of armor to damage
	 **/
	public void damageArmor (float amount) {
		float armorValue = this.armor;
		if (armorValue - amount > 0)
			this.setArmor (armorValue - amount);
		else {
			this.setArmor (0);
			Debug.Log ("Damage overflow of " + (amount-armorValue));
			damage (amount - armorValue);
		}
	}

	/**
	 * Knocks the object in the specified direction and power
	 * 
	 * @param	direction
	 * 		Either negative or positive, signifying left or right respectively
	 * @param	power
	 * 		The power of the knockback
	 **/
	public void knockback(int direction, float power, float upPower) {
		if (this.isDamageable) {
			Debug.Log ("Knocking back object for amount: " + power);
			rigidbody2D.AddForce (new Vector2 (direction * power, upPower));
			this.knockbackTime = 5;
			this.inKnockback = true;

			if (this.tag == "Player")
			{
				CameraLogic.ShakeItUp(0.25f, 0.2f, 1.0f);
				rigidbody2D.AddForce(new Vector2 (direction * power / 10, upPower / 10));
				GameObject player = GameObject.FindGameObjectWithTag("Player");
				player.GetComponent<CharacterKontroller>().movementEnabled = false;		// Disable player movement when hit
				player.GetComponent<CharacterKontroller>().reEnableMovementTimer = 0f;	// And reset the timer so it can count to threshold
			}
			if (this.tag == "Enemy")
			{
				this.GetComponent<ZombieFollow>().canMove = false;						// Same as if player.
				this.GetComponent<ZombieFollow>().reEnableMovementTimer = 0f;
			}
		}
	}

	/**
	 * Starts the invincibility frame counter
	 **/
	public void startIFrame() {
		this.isDamageable = false;
		this.iFrameTime = this.iFrameDuration;
	}

	/**
	 * Places a health bar above the object
	 **/
	public void updateHealthBar() {
		if (this.hasHealthBar)
			fhb.GetComponent<SpriteRenderer>().sprite = Resources.Load ("HPBars/hp" + (int)(healthPercentage * 10) + "0", typeof(Sprite)) as Sprite;
	}

	/**
	 * Sets the object's health to 0, thus calling the die() method through
	 * setHealth();
	 **/
	public void kill() {this.setHealth (0f);}

	void OnTriggerEnter2D(Collider2D other) {
		//Debug.Log ("-Projectile collision with damageable object-");
	}

	/**
	 * Destroys the object. This method should be overwritten.
	 **/
	void die() {
		Debug.Log ("Method die() triggered");
		this.isDead = true;
		Destroy (this.gameObject);
	}

	// Use this for initialization
	void Start () {
		this.Customize ();
		//Time.timeScale = 0.1f;
		this.health = this.maxHealth;
		//this.armor = this.maxArmor;

		sRenderer = GetComponent<SpriteRenderer>();

		// Instantiates health bar as a child of the parent
		if (this.hasHealthBar) {
			Transform parentTransform = GetComponent<Transform>();
			fhb = Instantiate(floatingHealthBar) as GameObject;
			fhb.transform.parent = parentTransform;
			fhb.transform.position = new Vector2(parentTransform.position.x, (float)(parentTransform.position.y + .3f));
		}		
	}

	// Customize the variables for the object, overriden in each object subclass
	public virtual void Customize () {
	}
	
	// Fixed update for invincibility frames
	void FixedUpdate () {
		if (this.iFrameDuration > 0 && this.iFrameTime > 0) {
			this.iFrameTime--;

			// Flips between opacity states
			if (this.iFrameTime % 10 < 5) sRenderer.color = new Color(1f,1f,1f,.5f);
			else sRenderer.color = new Color(1f,1f,1f,1f);
		}
		else if (this.iFrameTime >= 0) { // End invincibility
			sRenderer.color = new Color(1f,1f,1f,1f);
			this.setDamageable(true);
		}

		if (this.knockbackTime > 0)
			this.knockbackTime--;
		else if (this.knockbackTime <= 0)
			this.inKnockback = false;

		if (this.getHealth () > this.getMaxHealth())
			this.setHealth (this.getMaxHealth());

		if (hasHealthBar) {
			Vector2 tempScale = fhb.transform.localScale;
			Debug.Log("Scale is at: " + tempScale.x);
			if (tempScale.x < 0) {
				Debug.Log("Scale below 0");
				tempScale.x *= -1;// = new Vector2 (.25f, .25f);
				fhb.transform.localScale = tempScale;
			}
		}
		// Health bar above object - not implemented yet
		/* Health bar does not appear until object is hit
		if (hasHealthBar)
			updateHealthBar ();
		*/

	}

	// Regular update
	void Update () {
	}
}
