using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupScript : MonoBehaviour {
	
	GameObject player;
	InstrumentsOBJ instruments;
	ScalesOBJ scales;
	SongsOBJ songs;
	DamageableObject playerHealth;
	
	public bool trumpet = false;

	public bool eMajor = false;
	public bool eMinor = false;
	public bool fMajor = false;
	public bool fMinor = false;
	public bool gbMajor = false;
	public bool gbMinor = false;
	public bool gMajor = false;
	public bool gMinor = false;
	public bool abMajor = false;
	public bool abMinor = false;
	public bool aMajor = false;
	public bool aMinor = false;
	public bool bbMajor = false;
	public bool bbMinor = false;
	public bool bMajor = false;
	public bool bMinor = false;
	public bool cMinor = false;
	public bool dbMajor = false;
	public bool dbMinor = false;
	public bool dMajor = false;
	public bool dMinor = false;
	public bool ebMajor = false;
	public bool ebMinor = false;
	
	public bool MHLL = false;
	public bool OtJ = false; 
	public bool BotG = false;
	public bool Unra = false;

	public bool health10 = false,
				health25 = false,
				health50 = false,
				health100 = false;

	public bool armor10 = false,
				armor50 = false,
				armor100 = false;

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		instruments = player.GetComponent<InstrumentsOBJ> ();
		scales = player.GetComponent<ScalesOBJ> ();
		songs = player.GetComponent<SongsOBJ> ();
		playerHealth = player.GetComponent<DamageableObject> ();
	}
		
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			Unlock();
			Destroy (this.gameObject);
		}
	}
	
	void Unlock()
	{
		if (trumpet)
			instruments.instrumentList.Add (instruments.trumpet);

		if (eMajor)
			scales.scaleList.Add (ScalesOBJ.eMajor);
		if (eMinor)
			scales.scaleList.Add (ScalesOBJ.eMinor);
		if (fMajor)
			scales.scaleList.Add (ScalesOBJ.fMajor);
		if (fMinor)
			scales.scaleList.Add (ScalesOBJ.fMinor);
		if (gbMajor)
			scales.scaleList.Add (ScalesOBJ.gbMajor);
		if (gbMinor)
			scales.scaleList.Add (ScalesOBJ.gbMinor);
		if (gMajor)
			scales.scaleList.Add (ScalesOBJ.gMajor);
		if (gMinor)
			scales.scaleList.Add (ScalesOBJ.gMinor);		
		if (abMajor)
			scales.scaleList.Add (ScalesOBJ.abMajor);
		if (abMinor)
			scales.scaleList.Add (ScalesOBJ.abMinor);
		if (aMajor)
			scales.scaleList.Add (ScalesOBJ.aMajor);
		if (aMinor)
			scales.scaleList.Add (ScalesOBJ.aMinor);	
		if (bbMajor)
			scales.scaleList.Add (ScalesOBJ.bbMajor);
		if (bbMinor)
			scales.scaleList.Add (ScalesOBJ.bbMinor);
		if (bMajor)
			scales.scaleList.Add (ScalesOBJ.bMajor);
		if (bMinor)
			scales.scaleList.Add (ScalesOBJ.bMinor);
		if (cMinor)
			scales.scaleList.Add (ScalesOBJ.cMinor);
		if (dbMajor)
			scales.scaleList.Add (ScalesOBJ.dbMajor);
		if (dbMinor)
			scales.scaleList.Add (ScalesOBJ.dbMinor);
		if (dMajor)
			scales.scaleList.Add (ScalesOBJ.dMajor);
		if (dMinor)
			scales.scaleList.Add (ScalesOBJ.dMinor);
		if (ebMajor)
			scales.scaleList.Add (ScalesOBJ.ebMajor);
		if (health10)
			playerHealth.heal (10);
		if (health25)
			playerHealth.heal (25);
		if (health50)
			playerHealth.heal (50);
		if (health100)
			playerHealth.heal (100);
		if (armor10)
			playerHealth.addArmor (10);
		if (armor50)
			playerHealth.addArmor (50);
		if (armor100)
			playerHealth.addArmor (100);
			
		if (MHLL)
		{
			songs.comboList.Add (songs.MHLL1);
			songs.comboList.Add (songs.MHLL2);
			songs.comboList.Add (songs.MHLL3);
			songs.comboList.Add (songs.MHLL4);
			songs.significantComboList.Add (songs.MHLL4);
		}

		if (OtJ) 
		{
			songs.comboList.Add (songs.OtJ1);
			songs.comboList.Add (songs.OtJ2); 
			songs.significantComboList.Add (songs.OtJ2);
		}

		if (BotG) 
		{
			songs.comboList.Add (songs.BotG1);
			songs.comboList.Add (songs.BotG2);
			songs.comboList.Add (songs.BotG3);
			songs.significantComboList.Add (songs.BotG3);
		}

		if (Unra) 
		{
			songs.comboList.Add (songs.Unra1);
			songs.comboList.Add (songs.Unra2);
			songs.comboList.Add (songs.Unra3);
			songs.significantComboList.Add (songs.Unra3);
		}
	}

	
}
