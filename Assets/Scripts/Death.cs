using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    public float deathcounter = 3f;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Animals")
            deathcounter--;
        if (deathcounter == 0)
        {
            GameStateManager.GameState = GameState.Dead;
            SceneManager.LoadScene(2);
        }

    }
	// Update is called once per frame
	void Update () {
	
	}
}
