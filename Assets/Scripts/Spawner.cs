using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

    private GameObject SpawnObject;
    public GameObject[] SpawnObjects;
    public float timeMin = 0.7f;
    public float timeMax = 2f;
    
	// Use this for initialization
	void Start ()
    {
        //SpawnObject = SpawnObjects[Random.Range(0, SpawnObjects.Length)];
        Spawn();
	}
	
    void Spawn()
    {
        SpawnObject = SpawnObjects[Random.Range(0, SpawnObjects.Length)];

        if (GameStateManager.GameState == GameState.Playing)
        {
            float x = Random.Range(-2f, 2f);
            GameObject go = Instantiate(SpawnObject, this.transform.position + new Vector3(x, -10, 0), Quaternion.identity) as GameObject;

            if (ScoreManagerScript.Score >= 25)
                go.GetComponent<Rigidbody2D>().gravityScale = -0.8f;

            //Debug.Log(go.GetComponent<Rigidbody2D>().gravityScale);
        }
        Invoke("Spawn", Random.Range(timeMin, timeMax));

    
            
    }
	// Update is called once per frame
	void Update () {
	
	}
}
