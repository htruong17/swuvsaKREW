using UnityEngine;
using System.Collections;

public class CloudTween : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
		iTween.MoveAdd(gameObject, iTween.Hash("x", -0.01, "easeType", "linear", "loopType", "none", "none", 0));
	}
}
