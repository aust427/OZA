﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PickupScript : MonoBehaviour {
	
	GameObject player;
	InstrumentsOBJ instruments;
	ScalesOBJ scales;
	SongsOBJ songs;
	
	public bool trumpet = false;

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
	}

	
}
