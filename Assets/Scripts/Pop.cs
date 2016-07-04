using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Pop : MonoBehaviour {

    public float deathcounter = 3f;
	// Use this for initialization
	void Start () {
	
	}
	
    void OnMouseDown()
    {
        if (tag == "Trash")
        {
            Destroy(gameObject);
            deathcounter--;
            if (deathcounter == 0)
            {
                GameStateManager.GameState = GameState.Dead;
                SceneManager.LoadScene(2);
            }
        }
        else
            Destroy(gameObject);
    }
	// Update is called once per frame
	void Update ()
    {
	}
}
