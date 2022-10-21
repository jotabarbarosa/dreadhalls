using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelTextPro : MonoBehaviour
{
	public GameObject pickup;
	//public TextMeshProUGUI levelText;
	public TextMeshProUGUI levelText;

	// Use this for initialization
	void Start () {
		//levelnum = 0;
		levelText.text = "LEVEL: " + Pickup.nivel;
	}

	// Update is called once per frame
	void Update () {

	}
}




