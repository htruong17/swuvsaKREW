using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

	public Sprite[] heartSprite;
    
    // Use this for initialization
	void Start ()
    {
	}
    
	// Update is called once per frame
	void Update () {
        GetComponent<Image>().sprite = heartSprite[GameManager.deathcounter];
	}
}
