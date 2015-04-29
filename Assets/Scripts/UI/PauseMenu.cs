using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {

	public Canvas pauseShade;
	public static bool pauseMenuOpen = false;

	// Use this for initialization
	void Start () {
		pauseShade.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!MusicMenuScript.menuCurrentlyOpen && Input.GetKeyDown (KeyCode.Escape)) {
			if (pauseMenuOpen) {
				pauseShade.enabled = false;
				pauseMenuOpen = false;
				Time.timeScale = 1f;
			}
			else {
				Debug.Log ("Pause open");
				pauseShade.enabled = true;
				pauseMenuOpen = true;
				Time.timeScale = 0f;
			}
		}
	
	}
}
