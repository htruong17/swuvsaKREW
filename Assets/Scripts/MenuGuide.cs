using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuGuide : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	}

    public void Play ()
    {
        SceneManager.LoadScene(1);
        GameManager.deathcounter = 3;
        GameStateManager.GameState = GameState.Playing;
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
        GameStateManager.GameState = GameState.Intro;
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        else
            Time.timeScale = 1;
    }
}
