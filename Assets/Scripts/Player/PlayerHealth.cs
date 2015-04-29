using UnityEngine;
using System.Collections;

public class PlayerHealth : DamageableObject {

	public override void Customize() {
		this.setMaxHealth (1000);
		this.setIFrameDuration (50);
		this.setIsPlayer (true);
	}

}
