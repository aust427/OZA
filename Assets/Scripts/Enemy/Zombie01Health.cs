using UnityEngine;
using System.Collections;

public class Zombie01Health : DamageableObject {

	public override void Customize() {
		this.setMaxHealth (75);
		this.setHasHealthBar (true);
	}

}
