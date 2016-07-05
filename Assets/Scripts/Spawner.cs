using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Spawner : MonoBehaviour {

    private GameObject SpawnObject;
    public GameObject[] SpawnObjects;
	public int[] SpawnSize;
    public float timeMin = 0.7f;
    public float timeMax = 2f;

	private GameObject[] SpawnArray;
    
	// Use this for initialization
	void Start ()
    {
		List<GameObject> SpawnList = new List<GameObject>();
		for (int i = 0; i < SpawnObjects.Length; i++) {
			for (int objSize = 0; objSize < SpawnSize [i]; objSize++) {
				SpawnList.Add(SpawnObjects [i]);
			}
		}
		SpawnArray = SpawnList.ToArray ();
		Spawn ();
	}
	
    void Spawn()
    {
        SpawnObject = SpawnArray[Random.Range(0, SpawnArray.Length)];

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
