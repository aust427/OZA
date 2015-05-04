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
	public bool TtFaFC = false;
	public bool TtFaFI = false;
	public bool RadAct = false;
	public bool JttW = false;
	public bool MHWGOS = false;
	public bool MHWGOC = false;
	public bool FrWrk = false;
	public bool LaPB = false;
	public bool LHFWC = false;
	public bool YLLW = false;
	public bool HBtY = false;
	public bool WMUWSE = false; 
	public bool Beth5 = false;
	public bool Nmb = false;
	public bool Brkeven = false;
	public bool Pmpei = false;
	public bool StH = false;
	public bool KarChem = false;
	public bool DerBev = false;
	public bool IaSWAA = false;
	public bool Dova = false; 
	public bool GCeA = false;
	public bool ALS = false; 
	public bool PachD = false;
	public bool MrBri = false;
	
	
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
		// INSTRUMENTS
		if (trumpet)
			instruments.instrumentList.Add (instruments.trumpet);

		// SCALES
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
				
		// SONGS
		if (MHLL) //Mary Had a Little Lamb
		{
			songs.comboList.Add (songs.MHLL1);
			songs.comboList.Add (songs.MHLL2);
			songs.comboList.Add (songs.MHLL3);
			songs.comboList.Add (songs.MHLL4);
			songs.significantComboList.Add (songs.MHLL4);
		}
		if (OtJ) //Ode to Joy
		{
			songs.comboList.Add (songs.OtJ1);
			songs.comboList.Add (songs.OtJ2); 
			songs.significantComboList.Add (songs.OtJ2);
		}
		if (BotG) //Balled of the Goddess
		{
			songs.comboList.Add (songs.BotG1);
			songs.comboList.Add (songs.BotG2);
			songs.comboList.Add (songs.BotG3);
			songs.significantComboList.Add (songs.BotG3);
		}
		if (Unra) //Unravel
		{
			songs.comboList.Add (songs.Unra1);
			songs.comboList.Add (songs.Unra2);
			songs.comboList.Add (songs.Unra3);
			songs.significantComboList.Add (songs.Unra3);
		}
		if (TtFaFC) //Through the Fire and Flames Chorus
		{
			songs.comboList.Add (songs.TtFaFC1);
			songs.comboList.Add (songs.TtFaFC2);
			songs.comboList.Add (songs.TtFaFC3); 
			songs.significantComboList.Add (songs.TtFaFC3); 
		}
		if (TtFaFI) //Through the Fire and Flames Intro
		{
			songs.comboList.Add (songs.TtFaFI1);
			songs.comboList.Add (songs.TtFaFI2);
			songs.significantComboList.Add (songs.TtFaFI2);
		} 
		if (RadAct) //Radioactive
		{
			songs.comboList.Add (songs.RadAct1);
			songs.comboList.Add (songs.RadAct2);
			songs.significantComboList.Add (songs.RadAct2);
		}
		if (JttW) //Joy to the World
		{
			songs.comboList.Add (songs.JttW1);
			songs.comboList.Add (songs.JttW2);
			songs.comboList.Add (songs.JttW3);
			songs.significantComboList.Add (songs.JttW3);
		}
		if (MHWGOC) //My Heart Will Go On Chorus
		{
			songs.comboList.Add (songs.MHWGOC1);
			songs.comboList.Add (songs.MHWGOC2);
			songs.significantComboList.Add (songs.MHWGOC2);
		}
		if (MHWGOS) //My Heart Will Go On Solo
		{
			songs.comboList.Add (songs.MHWGOS1);
			songs.comboList.Add (songs.MHWGOS2);
			songs.significantComboList.Add (songs.MHWGOS2);
		}
		if (FrWrk) //Firework
		{
			songs.comboList.Add (songs.Firework1);
			songs.comboList.Add (songs.Firework2);
			songs.comboList.Add (songs.Firework3);
			songs.comboList.Add (songs.Firework4);
			songs.significantComboList.Add (songs.Firework4);
		}
		if (HBtY) //Happy Birthday to You
		{
			songs.comboList.Add (songs.HBtY1);
			songs.comboList.Add (songs.HBtY2);
			songs.comboList.Add (songs.HBtY3);
			songs.significantComboList.Add (songs.HBtY3);
		}
		if (LaPB) //Firework: Like a Plastic Bag
		{
			songs.comboList.Add (songs.LaPB1);
			songs.comboList.Add (songs.LaPB2);
			songs.comboList.Add (songs.LaPB3);
			songs.significantComboList.Add (songs.LaPB3);
		}
		if (WMUWSE) //Wake Me Up When September Ends
		{
			songs.comboList.Add (songs.WhenSept1);
			songs.comboList.Add (songs.WhenSept2);
			songs.significantComboList.Add (songs.WhenSept2);
		}
		if (Beth5) //Beethoven's 5th Symphony
		{
			songs.comboList.Add (songs.BSymp51);
			songs.comboList.Add (songs.BSymp52);
			songs.comboList.Add (songs.BSymp53);
			songs.comboList.Add (songs.BSymp54);
			songs.comboList.Add (songs.BSymp55);
			songs.comboList.Add (songs.BSymp56);
			songs.significantComboList.Add (songs.BSymp56);
		}
		if (DerBev) //Dearly Beloved
		{
			songs.comboList.Add (songs.DB1);
			songs.comboList.Add (songs.DB2);
			songs.comboList.Add (songs.DB3);
			songs.comboList.Add (songs.DB4);
			songs.significantComboList.Add (songs.DB4); 
		} 
		if (KarChem) //Karma Chemeleon
		{
			songs.comboList.Add(songs.KChem1);
			songs.comboList.Add(songs.KChem2);
			songs.comboList.Add(songs.KChem3);
			songs.comboList.Add(songs.KChem4);
			songs.significantComboList.Add (songs.KChem4);
		}
		if (StH) //Stairway to Heaven
		{
			songs.comboList.Add (songs.StarWay1);
			songs.comboList.Add (songs.StarWay2);
			songs.comboList.Add (songs.StarWay3);
			songs.comboList.Add (songs.StarWay4);
			songs.significantComboList.Add (songs.StarWay4);
		}
		if (Brkeven) //Breakeven
		{
			songs.comboList.Add (songs.Breakeven1);
			songs.comboList.Add (songs.Breakeven2);
			songs.comboList.Add (songs.Breakeven3);
			songs.comboList.Add (songs.Breakeven4);
			songs.significantComboList.Add (songs.Breakeven4);
		}
		if (Nmb) //Numb 
		{
			songs.comboList.Add (songs.Numb1);
			songs.comboList.Add (songs.Numb2);
			songs.comboList.Add (songs.Numb3);
			songs.significantComboList.Add (songs.Numb3);
		}
		if (Pmpei) //Pompeii
		{
			songs.comboList.Add (songs.Pomp1);
			songs.comboList.Add (songs.Pomp2);
			songs.comboList.Add (songs.Pomp3);
			songs.significantComboList.Add (songs.Pomp3);
		}
		if (MrBri)  //Mr. Brightside
		{
			songs.comboList.Add (songs.BrghtSde1);
			songs.comboList.Add (songs.BrghtSde2);
			songs.comboList.Add (songs.BrghtSde3);
			songs.significantComboList.Add (songs.BrghtSde3);
		}
		if (Dova) //Dovahkiin
		{
			songs.comboList.Add (songs.Dragbor1);
			songs.comboList.Add (songs.Dragbor2);
			songs.comboList.Add (songs.Dragbor3);
			songs.comboList.Add (songs.Dragbor4);
			songs.significantComboList.Add (songs.Dragbor4);
		}
		if (GCeA) //Gotta Catch 'Em All 
		{
			songs.comboList.Add (songs.CatchEm1);
			songs.comboList.Add (songs.CatchEm2);
			songs.comboList.Add (songs.CatchEm3);
			songs.comboList.Add (songs.CatchEm4);
			songs.significantComboList.Add (songs.CatchEm4);
		}
		if (ALS) //Auld Lang Syne
		{
			songs.comboList.Add (songs.Auld1);
			songs.comboList.Add (songs.Auld2);
			songs.significantComboList.Add (songs.Auld2);
		}
		if (PachD) //Pachabel's Canon in D
		{
			songs.comboList.Add (songs.CanonD1);
			songs.comboList.Add (songs.CanonD2);
			songs.comboList.Add (songs.CanonD3);
			songs.significantComboList.Add (songs.CanonD3);
		}
	/*	if (LHFWC) //Look How Far We've Come
		{
			
		}
		if (YLLW) //Yellow 
		{
			
		}
		if (IaSWAA)	//It's a Small World After All
		 {

		 }*/
		 
		// HEALTH / ARMOR
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
	}

	
}
