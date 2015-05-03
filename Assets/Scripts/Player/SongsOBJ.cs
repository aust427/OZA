using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SongsOBJ : MonoBehaviour 
{

	
	public List<Combo> comboList = new List<Combo>();		// Holds all songs unlocked by the player.
	public List<Combo> significantComboList = new List<Combo>();		// Holds all songs which get a button.
	public int specialAttackValue = 0;

	// Defines Combo object.
	public class Combo 
	{
		public string name;
		public ScalesOBJ.Scale scale;
		public int indexOfFullSong;			// The new "specialAttackValue." In multi-part songs, this number indicates which piece it is.
		public string songValue;			// The notes of a song as input by the numpad.
		public int intervals;				// The number of "beats" in any one song, in terms of the time between the first two notes of it.
		public float damage;				// The damage of any combo attack
		public string effect;				// The ID of the effect
		public bool finalPart;				// Controls whether there are more parts in any specific combo
		public string description;

		// Constructor for Combos.
		public Combo(string name, ScalesOBJ.Scale scale, int indexOfFullSong, string songValue, int intervals, float damage, string effect, bool finalPart, string description)
		{
			this.name = name;
			this.scale = scale;
			this.indexOfFullSong = indexOfFullSong;
			this.songValue = songValue;
			this.intervals = intervals;
			this.damage = damage;
			this.effect = effect;
			this.finalPart = finalPart;
			this.description = description;
		}
		

	}



	////// COMBO DEFINITIONS //////
	/// ("Song Name", "scale", "Part of Song", "Notes to Play it", "# of Notes Including Rests", "Damage", "Effect", "If End of Song", "Description")
	/// E Major

	/// E Minor

	/// F Major
	public Combo HBtY1 = new Combo ("Happy Birthday Song", ScalesOBJ.fMajor, 0, "1121431", 9, 4f, "Med", false, ""); 
	public Combo HBtY2 = new Combo ("Happy Birthday Song", ScalesOBJ.fMajor, 1, "1121431" + "121541", 9, 4f, "Med", false, "");
	public Combo HBtY3 = new Combo ("Happy Birthday Song", ScalesOBJ.fMajor, 2, "1121431" + "121541" + "186432665454", 15, 4f, "Med", true, "Happy Birthday!");

	/// F Minor
	public Combo LaPB1 = new Combo ("Like a Plastic Bag", ScalesOBJ.fMinor, 0, "57754344333443334433", 32, 4f, "Med", false, "");
	public Combo LaPB2 = new Combo ("Like a Plastic Bag", ScalesOBJ.fMinor, 1, "57754344333443334433"+"57754344333443334433", 32, 4f, "Med", false, "");
	public Combo LaPB3 = new Combo ("Like a Plastic Bag", ScalesOBJ.fMinor, 2, "57754344333443334433"+"57754344333443334433"+"57754344333443334433", 32, 4f, "Med", true, "A parody of Firework.");
	
	                               
	/// F#/Gb Major

	/// F#/Gb Minor

	/// G Major

	/// G Minor

	/// G#/Ab Major

	/// G#/Ab Minor

	/// A Major

	/// A Minor

	/// A#/Bb Major

	/// A#/Bb Minor

	/// B Major

	/// B Minor
	public Combo RadAct1 = new Combo ("Radioactive", ScalesOBJ.bMinor, 0, "888775777442", 16, 4f, "Med", false, "");
	public Combo RadAct2 = new Combo ("Radioactive", ScalesOBJ.bMinor, 1, "888775777442"+"5454515451545451333341", 22, 4f, "Med", true, "The 2012 hit by the band Imagine Dragons, Radioactive."); 

	/// C Major
	public Combo MHLL1 = new Combo ("Mary Had a Little Lamb", ScalesOBJ.cMajor, 0, "6545666", 7, 4f, "Arpegginade", false, "");			// Mary Had a Little Lamb
	public Combo MHLL2 = new Combo ("Mary Had a Little Lamb", ScalesOBJ.cMajor, 1, "6545666"+"555", 4, 10f, "Med", false, "");
	public Combo MHLL3 = new Combo ("Mary Had a Little Lamb", ScalesOBJ.cMajor, 2, "6545666"+"555"+"688", 4, 10f, "Med", false, "");
	public Combo MHLL4 = new Combo ("Mary Had a Little Lamb", ScalesOBJ.cMajor, 3, "6545666"+"555"+"688"+"6545666655654", 14, 20f, "SlowMed", true, "The first song programed into the game! Shoots debug garbage for now. Have fun.");
	
	public Combo Scale = new Combo("C Major Scale", ScalesOBJ.cMinor, 0, "123456789", 9, 10f, "Med", true, "A Test scale. This does not exist");
	
	public Combo OtJ1 = new Combo ("Ode to Joy", ScalesOBJ.cMajor, 0, "334554321123322", 16, 4f, "Med", false, "");
	public Combo OtJ2 = new Combo ("Ode to Joy", ScalesOBJ.cMajor, 1, "334554321123322"+"334554321123211", 16, 4f, "Arpegginade", true, "Arguably Beethoven's happiest song. A rendition of his 9th Symphony.");

	public Combo JttW1 = new Combo ("Joy to the World", ScalesOBJ.cMajor, 0, "87654321566778", 13, 4f, "Med", false, ""); 
	public Combo JttW2 = new Combo ("Joy to the World", ScalesOBJ.cMajor, 1, "87654321566778"+"8876554388765543", 16, 4f, "Med", false, "");
	public Combo JttW3 = new Combo ("Joy to the World", ScalesOBJ.cMajor, 2, "87654321566778"+"8876554388765543"+"33334543222343218654343218", 24, 4f, "Med", true, "A popular Christmas carol!");

	/// C Minor
	public Combo TtFaFC1 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 0, "55788874575", 15, 4f, "Med", false, "");
	public Combo TtFaFC2 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 1, "55788874575"+"34445435", 10, 4f, "Med", false, "");
	public Combo TtFaFC3 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 2, "55788874575"+"34445435"+"55788874575453344455578", 25, 4f, "Med", true, "The chorus from the song Through the Fire and Flames, by the band DragonForce. Possibly their most famous song, it was featured in the video game fanchise Guitar Hero.");
	
	public Combo TtFaFI1 = new Combo ("TtFaF (Intro)", ScalesOBJ.cMinor, 0, "313131313131515151515151414141414141313131212121", 32, 4f, "Med", false, "");
	public Combo TtFaFI2 = new Combo ("TtFaF (Intro)", ScalesOBJ.cMinor, 1, "313131313131515151515151414141414141313131212121"+"3313313133133131551551515515515144144141441411413313313122121121", 64, 4f, "Med", true, "The chorus from the song Through the Fire and Flames, by the band DragonForce. Infamous for it's difficulty, now you can experience it too!");

	/// C#/Db Major

	/// C#/Db Minor
	public Combo MHWGOS1 = new Combo ("Titanic Theme (Solo)", ScalesOBJ.dbMinor, 0, "344565434765312", 40, 4f, "Med", false, "");
	public Combo MHWGOS2 = new Combo ("Titanic Theme (Solo)", ScalesOBJ.dbMinor, 1, "344565434765312"+"344565434757855543", 40, 4f, "Med", true, "The pennywhistle solo for the song My Heart Will Go On.");

	public Combo MHWGOC1 = new Combo ("Titanic Theme (Chorus)", ScalesOBJ.dbMinor, 0, "334476545654323212", 32, 4f, "Med", false, ""); 
	public Combo MHWGOC2 = new Combo ("Titanic Theme (Chorus)", ScalesOBJ.dbMinor, 1, "334476545654323212" + "3344765456543233234565433", 40, 4f, "Med", true, "The chorus for the song My Heart Will Go On.");

	/// D Major

	/// D Minor
	public Combo BotG1 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 0, "1323478542", 24, 4f, "Med", false, ""); 
	public Combo BotG2 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 1, "1323478542"+"111422111422", 24, 4f, "Med", false, ""); 
	public Combo BotG3 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 2, "1323478542"+"111422111422"+"13234785421132778", 36, 4f, "Med", true, "Formally known as Ballad of the Goddess, this is the main theme of the 2011 Game, The Legend of Zelda: Skward Sword. Fun fact is that if you played the song backwards, it sounds a lot like Zelda's Lullaby."); 
	
	public Combo Unra1 = new Combo ("Unravel", ScalesOBJ.dMinor, 0, "18778777665653", 16, 4f, "Med", false, ""); 
	public Combo Unra2 = new Combo ("Unravel", ScalesOBJ.dMinor, 1, "18778777665653"+"38777665686", 12, 4f, "Med", false, ""); 
	public Combo Unra3 = new Combo ("Unravel", ScalesOBJ.dMinor, 2, "18778777665653"+"38777665686"+"68756665456", 12, 4f, "Med", true, "The opening theme of the 2014 anime, Tokyo Ghoul. The song is originally by TK from Ling Tosite Sigure."); 
	
	// For debug purposes, initialize with songs in the list.
	void Awake()
	{
	//	comboList.Add (MHLL1);
	//	comboList.Add (MHLL2);
	//	comboList.Add (MHLL3);
	//	comboList.Add (MHLL4);
	}
	
	
	public string[] getNotesArray(Combo combo)
	{
		//	E	F	F#	G	Ab	A	Bb	B	C	C#	D	Eb
		//	0	1	2	3	4	5	6	7	8	9	10	11
		char[] rawNotes = combo.songValue.ToCharArray();
		string[] notesArray = new string[combo.songValue.Length];
		for (int i = 0; i < notesArray.Length; i ++)
		{
			notesArray[i] = rawNotes[i].ToString();			// Copies the base values of the notes to the string array.
			
			//int correctionFactor = 0;	// Accounts for the intervals of major and minor keys.
			// Base corrections for major keys
			// The weird spaces at the end of the corrections stop corrections from being overwritten, but still allow Parse to work later. It's a hack.
			if (combo.scale.major)
			{
				if (notesArray[i].Equals("1")) notesArray[i] = "0 ";
				if (notesArray[i].Equals("2")) notesArray[i] = "2 ";
				if (notesArray[i].Equals("3")) notesArray[i] = "4 ";
				if (notesArray[i].Equals("4")) notesArray[i] = "5 ";
				if (notesArray[i].Equals("5")) notesArray[i] = "7 ";
				if (notesArray[i].Equals("6")) notesArray[i] = "9 ";
				if (notesArray[i].Equals("7")) notesArray[i] = "11 ";
				if (notesArray[i].Equals("8")) notesArray[i] = "12 ";
				if (notesArray[i].Equals("9")) notesArray[i] = "14 ";
			}
			// Base corrections for minor keys
			else
			{
				if (notesArray[i].Equals("1")) notesArray[i] = "0 ";
				if (notesArray[i].Equals("2")) notesArray[i] = "2 ";
				if (notesArray[i].Equals("3")) notesArray[i] = "3 ";
				if (notesArray[i].Equals("4")) notesArray[i] = "5 ";
				if (notesArray[i].Equals("5")) notesArray[i] = "7 ";
				if (notesArray[i].Equals("6")) notesArray[i] = "8 ";
				if (notesArray[i].Equals("7")) notesArray[i] = "10 ";
				if (notesArray[i].Equals("8")) notesArray[i] = "12 ";
				if (notesArray[i].Equals("9")) notesArray[i] = "14 ";
			}
			
			
			notesArray[i] = ((int.Parse(notesArray[i]) + combo.scale.root) % 12).ToString();	// Maths it to translateable offsets
			
			
			if (notesArray[i].Equals("0")) notesArray[i] = "E";			// The follwing 12 statements translate the array to the actual notes.
			if (notesArray[i].Equals("1")) notesArray[i] = "F";			// ♯♭
			if (notesArray[i].Equals("2")) notesArray[i] = "F#";
			if (notesArray[i].Equals("3")) notesArray[i] = "G";
			if (notesArray[i].Equals("4")) notesArray[i] = "Ab";
			if (notesArray[i].Equals("5")) notesArray[i] = "A";
			if (notesArray[i].Equals("6")) notesArray[i] = "Bb";
			if (notesArray[i].Equals("7")) notesArray[i] = "B";
			if (notesArray[i].Equals("8")) notesArray[i] = "C";
			if (notesArray[i].Equals("9")) notesArray[i] = "C#";
			if (notesArray[i].Equals("10")) notesArray[i] = "D";
			if (notesArray[i].Equals("11")) notesArray[i] = "Eb";
		}
		
		return notesArray;
	}
	public string[] getNotesOfScale(int root, bool major)
	{
		string[] notesArray = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
		ScalesOBJ.Scale scaleToTest = new ScalesOBJ.Scale("Scale", root, major, "This scale should not exist");
		Combo scaleNotes = new Combo("Scale", scaleToTest, 0, "123456789", 9, 9001f, "(╯°□°)╯︵ ┻━┻", true, "Wat.");
		return getNotesArray(scaleNotes);
	}


}