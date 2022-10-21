using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Pickup : MonoBehaviour {

	// Reference text level label on play scene canvas
	public TextMeshProUGUI levelText;

	// Declare static level variable  to keep track of num levels
	public static int nivel = 0;

	// Use this for initialization
	void Start () {
	    levelText.text = ("LEVEL: " + nivel);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0, 5f, 0, Space.World);
	}



	void OnTriggerEnter(Collider other) {

			nivel += 1;

			Debug.Log(nivel);
			
			SceneManager.LoadScene("Play");
	}


}
