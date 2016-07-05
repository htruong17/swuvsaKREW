using UnityEngine;
using System.Collections;

public class Sunset : MonoBehaviour {

	// Use this for initialization
	void Start () {
		iTween.FadeFrom(gameObject, iTween.Hash("alpha", 0f, "amount", 1f, "time", 6f, "easeType", "linear", "loopType", "pingPong"));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
