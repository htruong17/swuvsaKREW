using UnityEngine;
using System.Collections;

public class BubbleDestroyer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "BubbleDestroyer")
            Destroy(gameObject);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
