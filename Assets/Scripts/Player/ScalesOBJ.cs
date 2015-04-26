using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ScalesOBJ : MonoBehaviour 
{
	GameObject player;									// Ref to player
	CombatControllerIII combat;							// Ref to combat script
	public List<Scale> scaleList = new List<Scale>();	// The list of all scales unlocked
	
	public bool currentKeyMajor = true;
	public int currentRoot = 8;
	public Scale currentScale;

	void Awake ()
	{
		currentScale = cMajor; // Init so buttons know what color to be.
						
		player = GameObject.FindGameObjectWithTag ("Player"); //Initialize player references.
		combat = player.GetComponent<CombatControllerIII>();
		// DEBUG: Adds cMajor and Minor to the list, for testing purposes.
		scaleList.Add (cMajor);
		//scaleList.Add (cMinor);
		
	}

	public class Scale
	{
		public string name;		// Instance vars
		public int root;		
		public bool major;
		public string description;

		// Constructor for scales
		public Scale(string name, int root, bool major, string description)
		{
			this.name = name;
			this.root = root;
			this.major = major;
			this.description = description;
		}

	}


	////// COMBO DEFINITIONS //////
	public static Scale aMajor = new Scale ("A Major", 5, true, "A Major."); 
	public static Scale aMinor = new Scale ("A Minor", 5, false, "A minor. We really need to think of puns like soon."); 
	public static Scale bbMajor = new Scale ("A#/Bb Major", 6, true, "A# Major. Also known as Bb Major."); 
	public static Scale bbMinor = new Scale ("A#/Bb Minor", 6, false, "A# minor. We really need to think of puns like soon."); 
	public static Scale bMajor = new Scale ("B Major", 7, true, "B Major."); 
	public static Scale bMinor = new Scale ("B Minor", 7, false, "B minor. We really need to think of puns like soon."); 
	public static Scale cMajor = new Scale ("C Major", 8, true, "This is a C Major scale. Puns go here.");
	public static Scale cMinor = new Scale ("C Minor", 8, false, "C minor needs a description, too.");
	public static Scale dbMajor = new Scale ("C#/Db Major", 9, true, "C# Major. Also known as Db Major.");
	public static Scale dbMinor = new Scale ("C#/Db Minor", 9, false, "C# minor. Also known as Db minor."); 
	public static Scale dMajor = new Scale ("D Major", 10, true, "This is a D Major scale. Puns go here.");
	public static Scale dMinor = new Scale ("D Minor", 10, false, "D minor needs a description, too.");
	public static Scale ebMajor = new Scale ("D#/Eb Major", 11, true, "Eb Major. Also known as D# Major."); 
	public static Scale ebMinor = new Scale ("D#/Eb Minor", 11, false, "Eb minor. Also known as D# minor."); 
	
	// The change key function
	public void ChangeKey(Scale scale)
	{
		if (scale.major)
		{
			combat.ChangeKeyMajor (scale.root);
			currentScale = scale;
			currentKeyMajor = true;
			currentRoot = scale.root;
		}
		else
		{
			combat.ChangeKeyMinor (scale.root);
			currentScale = scale;
			currentKeyMajor = false;
			currentRoot = scale.root;
		}
	}


}
