using UnityEngine;
using System.Collections;

public class CustomHitSound : MonoBehaviour {
	public string customHitSoundName = "Generic/HitSound";
	public AudioClip sound;
	
	void Awake ()
	{
		sound = Resources.Load ("Sounds/" + customHitSoundName) as AudioClip;
	}
}
