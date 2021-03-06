﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SongController : MonoBehaviour 
{
	GameObject player;
	SongsOBJ songs;
	GameObject songController;
	
	public Text scaleBox;
	public GameObject preview;
	public Text description;
	Text[] noteTextBoxes;

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag("Player");
		songs = player.GetComponent<SongsOBJ>();
		songController = this.gameObject;
		noteTextBoxes = songController.GetComponentsInChildren<Text>();
	}

	public void SetInfo(SongsOBJ.Combo newSong)
	{
		Sprite previewSprite = Resources.Load<Sprite> ("MenuFrameContents/Song/" + newSong.name);
		string newDesc = newSong.description;
		
		scaleBox.text = newSong.scale.name;
		preview.GetComponent<Image>().sprite = previewSprite;
		description.text = newDesc;
		SetAllSongNotes(newSong);
	
	
	}
	
	public void SetAllSongNotes(SongsOBJ.Combo newSong)	// FOR THE NOTES
	{
		string[] notes = songs.getNotesArray(newSong);
		for (int i = 0; i < noteTextBoxes.Length; i++)	// Clear it first for a fresh state.
		{
			noteTextBoxes[i].text = "";
		}
		for (int i = 0; i < notes.Length; i++)			// Put in the notes.
		{
			noteTextBoxes[i].text = notes[i];
		}
	}
	public void SetAllSongNumbers(SongsOBJ.Combo newSong) // FOR THE NUMBERS
	{
		string[] notes = songs.getNumbersArray(newSong);
		for (int i = 0; i < noteTextBoxes.Length; i++)	// Clear it first for a fresh state.
		{
			noteTextBoxes[i].text = "";
		}
		for (int i = 0; i < notes.Length; i++)			// Put in the notes.
		{
			noteTextBoxes[i].text = notes[i];
		}
	}
}
