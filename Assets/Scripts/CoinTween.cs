using UnityEngine;
using System.Collections;

public class CoinTween : MonoBehaviour
{
	void Start(){
		iTween.RotateBy(gameObject, iTween.Hash("z", 10, "easeType", "linear", "time",15,"loopType", "pingPong", "delay", 0));
	}
}

