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
	
	public Combo Firework1 = new Combo ("Firework", ScalesOBJ.fMinor, 0, "7654435", 16, 4f, "Med", false, "");
	public Combo Firework2 = new Combo ("Firework", ScalesOBJ.fMinor, 1, "7654435"+"7654431", 16, 4f, "Med", false, "");
	public Combo Firework3 = new Combo ("Firework", ScalesOBJ.fMinor, 2, "7654435"+"7654431"+"7654445", 12, 4f, "Med", false, "");
	public Combo Firework4 = new Combo ("Firework", ScalesOBJ.fMinor, 3, "7654435"+"7654431"+"7654445"+"76544431", 12, 4f, "Med", true, "Katy Perry's Firework.");

	/// F#/Gb Major

	/// F#/Gb Minor
	public Combo Numb1 = new Combo ("Numb", ScalesOBJ.gbMinor, 0, "55588785559799", 16, 4f, "Med", false, "");
	public Combo Numb2 = new Combo ("Numb", ScalesOBJ.gbMinor, 1, "55588785559799"+"8887888897", 8, 4f, "Med", false, "");
	public Combo Numb3 = new Combo ("Numb", ScalesOBJ.gbMinor, 2, "55588785559799"+"8887888897"+"8887888878", 8, 4f, "Med", true, "");

	/// G Major
	public Combo WhenSept1 = new Combo ("When September Ends", ScalesOBJ.gMajor, 0, "23123323316532152151123", 12, 4f, "Med", false, "");
	public Combo WhenSept2 = new Combo ("When September Ends", ScalesOBJ.gMajor, 1, "23123323316532152151123"+"2332332334321152151123", 12, 4f, "Med", true, "The Green Day single, Wake Me Up When September Ends.");

	/// G Minor
	public Combo Breakeven1 = new Combo ("Breakeven", ScalesOBJ.gMinor, 0, "555334353", 10, 4f, "Med", false, "");
	public Combo Breakeven2 = new Combo ("Breakeven", ScalesOBJ.gMinor, 1, "555334353"+"555334353", 10, 4f, "Med", false, "");
	public Combo Breakeven3 = new Combo ("Breakeven", ScalesOBJ.gMinor, 1, "555334353"+"555334353"+"55785444543", 14, 4f, "Med", false, "");
	public Combo Breakeven4 = new Combo ("Breakeven", ScalesOBJ.gMinor, 1, "555334353"+"555334353"+"55785444543"+"555334353", 10, 4f, "Med", false, "");

	/// G#/Ab Major

	/// G#/Ab Minor

	/// A Major
	public Combo Pomp1 = new Combo ("Pompeii", ScalesOBJ.aMajor, 0, "111321", 7, 4f, "Med", false, "");
	public Combo Pomp2 = new Combo ("Pompeii", ScalesOBJ.aMajor, 1, "111321"+"11532122212111321", 16, 4f, "Med", false, "");
	public Combo Pomp3 = new Combo ("Pompeii", ScalesOBJ.aMajor, 2, "111321"+"11532122212111321"+"1153212221222256", 16, 4f, "Med", true, "");

	/// A Minor
	public Combo StarWay1 = new Combo ("Stairway to Heaven", ScalesOBJ.aMinor, 0, "123212123431", 14, 4f, "Med", false, "");
	public Combo StarWay2 = new Combo ("Stairway to Heaven", ScalesOBJ.aMinor, 1, "123212123431"+"3454342778", 8, 4f, "Med", false, "");
	public Combo StarWay3 = new Combo ("Stairway to Heaven", ScalesOBJ.aMinor, 2, "123212123431"+"3454342778"+"322321", 2, 4f, "Med", false, "");
	public Combo StarWay4 = new Combo ("Stairway to Heaven", ScalesOBJ.aMinor, 3, "123212123431"+"3454342778"+"322321"+"322321", 2, 4f, "Med", true, "Stairway to Heaven Yay.");

	/// A#/Bb Major
	public Combo CatchEm1 = new Combo ("Gotta Catch 'Em All", ScalesOBJ.bbMajor, 0, "35633566555", 12, 4f, "Med", false, "");
	public Combo CatchEm2 = new Combo ("Gotta Catch 'Em All", ScalesOBJ.bbMajor, 1, "35633566555"+"6678765", 8, 4f, "Med", false, "");
	public Combo CatchEm3 = new Combo ("Gotta Catch 'Em All", ScalesOBJ.bbMajor, 2, "35633566555"+"6678765"+"4888588", 12, 4f, "Med", false, "");
	public Combo CatchEm4 = new Combo ("Gotta Catch 'Em All", ScalesOBJ.bbMajor, 3, "35633566555"+"6678765"+"4888588"+"88873356633566356", 8, 4f, "Med", true, "The theme to the Pokemon anime");

	public Combo KChem1 = new Combo ("Karma Chameleon", ScalesOBJ.bbMajor, 0, "33333333222321", 14, 4f, "Med", false, "");
	public Combo KChem2 = new Combo ("Karma Chemeleon", ScalesOBJ.bbMajor, 1, "33333333222321"+"11123211232", 16, 4f, "Med", false, "");
	public Combo KChem3 = new Combo ("Karma Chemeleon", ScalesOBJ.bbMajor, 2, "33333333222321"+"11123211232"+"33333333222321", 14, 4f, "Med", false, "");
	public Combo KChem4 = new Combo ("Karma Chemeleon", ScalesOBJ.bbMajor, 3, "33333333222321"+"11123211232"+"33333333222321"+"11123211", 16, 4f, "Med", true, "My roommate wakes me up with this song.");

	/// A#/Bb Minor

	/// B Major

	/// B Minor
	public Combo RadAct1 = new Combo ("Radioactive", ScalesOBJ.bMinor, 0, "888775777442", 16, 4f, "Med", false, "");
	public Combo RadAct2 = new Combo ("Radioactive", ScalesOBJ.bMinor, 1, "888775777442"+"5454515451545451333341", 22, 4f, "Med", true, "The 2012 hit by the band Imagine Dragons, Radioactive."); 

	public Combo Dragbor1 = new Combo ("Dovahkiin", ScalesOBJ.bMinor, 0, "123345574321", 24, 4f, "Med", false, "");
	public Combo Dragbor2 = new Combo ("Dovahkiin", ScalesOBJ.bMinor, 1, "123345574321"+"123345578798", 24, 4f, "Med", false, "");
	public Combo Dragbor3 = new Combo ("Dovahkiin", ScalesOBJ.bMinor, 2, "123345574321"+"123345578798"+"893217654354", 24, 4f, "Med", false, "");
	public Combo Dragbor4 = new Combo ("Dovahkiin", ScalesOBJ.bMinor, 3, "123345574321"+"123345578798"+"893217654354"+"323323324321878878878978", 24, 4f, "Med", true, "The main theme to the 2011 game, The Elder Scrolls V: Skryim");

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

	public Combo Auld1 = new Combo ("Auld Lang Syne", ScalesOBJ.cMajor, 0, "543465456544689", 13, 4f, "Med", false, "");
	public Combo Auld2 = new Combo ("Auld Lang Syne", ScalesOBJ.cMajor, 1, "543465456544689"+"986645456542214", 13, 4f, "Med", true, "Happy New Year!");

	/// C Minor
	public Combo TtFaFC1 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 0, "55788874575", 15, 4f, "Med", false, "");
	public Combo TtFaFC2 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 1, "55788874575"+"34445435", 10, 4f, "Med", false, "");
	public Combo TtFaFC3 = new Combo ("TtFaF (Chorus)", ScalesOBJ.cMinor, 2, "55788874575"+"34445435"+"55788874575453344455578", 25, 4f, "Med", true, "The chorus from the song Through the Fire and Flames, by the band DragonForce. Possibly their most famous song, it was featured in the video game fanchise Guitar Hero.");
	
	public Combo TtFaFI1 = new Combo ("TtFaF (Intro)", ScalesOBJ.cMinor, 0, "313131313131515151515151414141414141313131212121", 32, 4f, "Med", false, "");
	public Combo TtFaFI2 = new Combo ("TtFaF (Intro)", ScalesOBJ.cMinor, 1, "313131313131515151515151414141414141313131212121"+"3313313133133131551551515515515144144141441411413313313122121121", 64, 4f, "Med", true, "The chorus from the song Through the Fire and Flames, by the band DragonForce. Infamous for it's difficulty, now you can experience it too!");

	public Combo BSymp51 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 4, "5553", 4, 4f, "Med", false, "");
	public Combo BSymp52 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 4, "5553"+"4442", 4, 4f, "Med", false, "");
	public Combo BSymp53 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 4, "5553"+"4442"+"5553333866642227", 16, 4f, "Med", false, "");
	public Combo BSymp54 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 4, "5553"+"4442"+"5553333866642227"+"554355435543", 17, 4f, "Med", false, "");
	public Combo BSymp55 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 4, "5553"+"4442"+"5553333866642227"+"554355435543"+"1", 1, 4f, "Med", false, "");
	public Combo BSymp56 = new Combo ("Beethoven's 5th", ScalesOBJ.cMinor, 5, "5553"+"4442"+"5553333866642227"+"554355435543"+"1"+"5", 1, 4f, "Med", true, "Sigh.");

	/// C#/Db Major
	public Combo BrghtSde1 = new Combo ("Mr. Brightside", ScalesOBJ.dbMajor, 0, "7887888788", 8, 4f, "Med", false, "");
	public Combo BrghtSde2 = new Combo ("Mr. Brightside", ScalesOBJ.dbMajor, 1, "7887888788"+"11124334321211", 16, 4f, "Med", false, "");
	public Combo BrghtSde3 = new Combo ("Mr. Brightside", ScalesOBJ.dbMajor, 2, "7887888788"+"11124334321211"+"111243313212", 16, 4f, "Med", true, "Mr. Brightside by The Killers.");

	/// C#/Db Minor
	public Combo MHWGOS1 = new Combo ("Titanic Theme (Solo)", ScalesOBJ.dbMinor, 0, "344565434765312", 40, 4f, "Med", false, "");
	public Combo MHWGOS2 = new Combo ("Titanic Theme (Solo)", ScalesOBJ.dbMinor, 1, "344565434765312"+"344565434757855543", 40, 4f, "Med", true, "The pennywhistle solo for the song My Heart Will Go On.");

	public Combo MHWGOC1 = new Combo ("Titanic Theme (Chorus)", ScalesOBJ.dbMinor, 0, "334476545654323212", 32, 4f, "Med", false, ""); 
	public Combo MHWGOC2 = new Combo ("Titanic Theme (Chorus)", ScalesOBJ.dbMinor, 1, "334476545654323212" + "3344765456543233234565433", 40, 4f, "Med", true, "The chorus for the song My Heart Will Go On.");

	/// D Major
	public Combo CanonD1 = new Combo ("Canon in D", ScalesOBJ.dMajor, 0, "87654345", 8, 4f, "Med", false, "");
	public Combo CanonD2 = new Combo ("Canon in D", ScalesOBJ.dMajor, 1, "87654345"+"87654345", 8, 4f, "Med", false, "");
	public Combo CanonD3 = new Combo ("Canon in D", ScalesOBJ.dMajor, 2, "87654345"+"87654345"+"876543453", 9, 4f, "Med", false, "");

	/// D Minor
	public Combo BotG1 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 0, "1323478542", 24, 4f, "Med", false, ""); 
	public Combo BotG2 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 1, "1323478542"+"111422111422", 24, 4f, "Med", false, ""); 
	public Combo BotG3 = new Combo ("Skward Sword Theme", ScalesOBJ.dMinor, 2, "1323478542"+"111422111422"+"13234785421132778", 36, 4f, "Med", true, "Formally known as Ballad of the Goddess, this is the main theme of the 2011 Game, The Legend of Zelda: Skward Sword. Fun fact is that if you played the song backwards, it sounds a lot like Zelda's Lullaby."); 
	
	public Combo Unra1 = new Combo ("Unravel", ScalesOBJ.dMinor, 0, "18778777665653", 16, 4f, "Med", false, ""); 
	public Combo Unra2 = new Combo ("Unravel", ScalesOBJ.dMinor, 1, "18778777665653"+"38777665686", 12, 4f, "Med", false, ""); 
	public Combo Unra3 = new Combo ("Unravel", ScalesOBJ.dMinor, 2, "18778777665653"+"38777665686"+"68756665456", 12, 4f, "Med", true, "The opening theme of the 2014 anime, Tokyo Ghoul. The song is originally by TK from Ling Tosite Sigure."); 

	/// D#/Eb Major 
	public Combo DB1 = new Combo ("Dearly Beloved", ScalesOBJ.ebMajor, 0, "66332277", 8, 4f, "Med", false, "");
	public Combo DB2 = new Combo ("Dearly Beloved", ScalesOBJ.ebMajor, 1, "66332277"+"66332277", 8, 4f, "Med", false, "");
	public Combo DB3 = new Combo ("Dearly Beloved", ScalesOBJ.ebMajor, 2, "66332277"+"66332277"+"88773322", 8, 4f, "Med", false, "");
	public Combo DB4 = new Combo ("Dearly Beloved", ScalesOBJ.ebMajor, 3, "66332277"+"66332277"+"88773322"+"117766556", 9, 4f, "Med", true, "The title theme of the Kingdom Hearts series.");

	/// D#/Eb Minor


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