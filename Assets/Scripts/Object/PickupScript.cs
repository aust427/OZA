using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupScript : MonoBehaviour {
	
	GameObject player;
	InstrumentsOBJ instruments;
	ScalesOBJ scales;
	SongsOBJ songs;
	
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
	public bool Imm = false;
	public bool Brkeven = false;
	public bool Pmpei = false;
	public bool StH = false;
	public bool KarChem = false;
	public bool DerBev = false;
	public bool IaSWAA = false;
	
	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
		instruments = player.GetComponent<InstrumentsOBJ> ();
		scales = player.GetComponent<ScalesOBJ> ();
		songs = player.GetComponent<SongsOBJ> ();
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

		}
		if (Beth5) //Beethoven's 5th Symphony
		{

		}
		if (DerBev) //Dearly Beloved
		{

		}
		if (KarChem) //Karma Chemeleon
		{

		}
		if (StH) //Stairway to Heaven
		{

		}
		if (Brkeven)
		{
			
		}
		if (Imm)
		{
			
		}
		if (Pmpei)
		{
			
		}
/*		if (LHFWC) //Look How Far We've Come
		{
			
		}
		if (YLLW) //Yellow 
		{
			
		}
		if (IaSWAA)	//It's a Small World After All
		 {

		 }*/
	}

	
}
