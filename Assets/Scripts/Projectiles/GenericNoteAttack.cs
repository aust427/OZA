using UnityEngine;
using System.Collections;

public class GenericNoteAttack : CustomProjectile {
	/**
	 * Damages the enemy on hit
	 **/
	
	AudioClip hitSound;
	
	void Awake ()
	{
		hitSound = Resources.Load("Sounds/Generic/HitSound") as AudioClip;
	}
	
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Enemy") {
			DamageableObject enemy = other.gameObject.GetComponent<DamageableObject> ();
			CustomHitSound customHitSound = other.gameObject.GetComponent<CustomHitSound>();
			if (customHitSound == null)
			{
				AudioSource.PlayClipAtPoint(hitSound, other.transform.position);	// Default
			}
			else
			{
				hitSound = customHitSound.sound;
				AudioSource.PlayClipAtPoint(hitSound, other.transform.position);	// Use custom
			}
			
			int directionKnockback;
			if (transform.position.x - enemy.transform.position.x > 0)
				directionKnockback = -1;
			else
				directionKnockback = 1;
			
			enemy.knockback (directionKnockback,this.getKnockback (),this.getKnockbackVertical());
			enemy.damage (this.getDamage ());
			this.die (true);
		}
	}
}
