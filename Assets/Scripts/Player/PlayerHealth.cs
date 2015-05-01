using UnityEngine;
using System.Collections;

public class PlayerHealth : DamageableObject {

	public override void Customize() {
		this.setMaxHealth (100);
		this.setIFrameDuration (50);
		this.setMaxArmor (100);
		this.setArmor (5);
		this.setHasHealthBar (false);
	}

}
