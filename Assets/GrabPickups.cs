using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GrabPickups : MonoBehaviour {
	
	// Reference text level label on play scene canvas
	public TextMeshProUGUI levelText;
	
	// Declare static level variable  to keep track of num levels
	public static int nivel = 0;
	//private int niveltest = 1;
	
	void start() {
		//show level on the screen
		levelText.text = ("LEVEL: " + nivel);
	
	}
	
	void OnControllerColliderHit(ControllerColliderHit hit) {
		
		// if colide with Pickup add nivel + 1 and call play scene	
		if (hit.gameObject.tag == "Pickup") {
			// add one to the level number

			nivel += 1;

			
			Debug.Log(hit.gameObject.tag);
			SceneManager.LoadScene("Play");
		}
	}
	
	
	
}
