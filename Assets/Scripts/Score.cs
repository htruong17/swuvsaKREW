using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int scoreValue = 0;


	// Use this for initialization
	void Start () {
		scoreValue = 0;
	}
	
	// Update is called once per frame
	void Update () {

	    GetComponent<Text>().text = "Score: " + scoreValue;

	}
}
