using UnityEngine;
using System.Collections;

public class MoveSample : MonoBehaviour
{	
	void Update(){
		iTween.MoveAdd(gameObject, iTween.Hash("x", -1, "easeType", "linear", "loopType", "none", "none", 0));
	}
}

