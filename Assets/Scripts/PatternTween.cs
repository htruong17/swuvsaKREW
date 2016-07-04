using UnityEngine;
using System.Collections;

public class PatternTween : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	void Update(){
		iTween.MoveAdd(gameObject, iTween.Hash("x", 2.25, "easeType", "linear", "loopType", "loop", "none", 0));
	}
}
