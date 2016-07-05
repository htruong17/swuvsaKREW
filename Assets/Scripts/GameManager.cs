using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TouchScript.Gestures;
using System;


public class GameManager : MonoBehaviour
{

    public static int deathcounter = 3;
    public int creatureValue;

    void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (this.tag == "Animals" && col.tag == "BubbleDestroyer")
        {
            Destroy(gameObject);
            deathcounter--;
        }
        else if (col.tag == "BubbleDestroyer")
            Destroy(gameObject);
        if (deathcounter == 0)
        {
            GameStateManager.GameState = GameState.Dead;
            SceneManager.LoadScene(2);
        }
    }

    private void OnEnable()
    {
        GetComponent<PressGesture>().Pressed += pressedHandler;
    }

    private void OnDisble()
    {
        GetComponent<PressGesture>().Pressed -= pressedHandler;
    }
    private void pressedHandler(object sender, EventArgs e)
    {
        if (Time.timeScale == 1)
        {
            if (tag == "Trash")
            {
				iTween.PunchScale (gameObject, iTween.Hash ("amount", new Vector3 (0.2f, 0.2f, 0), "time", 1.7f, "easetype", iTween.EaseType.linear));
                Destroy(gameObject,0.1f);
                deathcounter--;
            }
            else if (tag == "Life")
            {
                Destroy(gameObject);
                deathcounter++;
            }
            else
            {
				iTween.PunchScale (gameObject, iTween.Hash ("amount", new Vector3 (0.2f, 0.2f, 0), "time", 1.7f, "easetype", iTween.EaseType.linear));
                ScoreManagerScript.Score += creatureValue;
                Destroy(gameObject,0.1f);
            }
            if (deathcounter == 0)
            {
                GameStateManager.GameState = GameState.Dead;
                SceneManager.LoadScene(2);
            }
        }
    }
}

