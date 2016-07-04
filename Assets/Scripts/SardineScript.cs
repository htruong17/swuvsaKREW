using UnityEngine;
using System.Collections;
using TouchScript.Gestures;

public class SardineScript : MonoBehaviour {

    public GameObject sardine;
    public float Power = 10.0f;
    private Vector3[] directions =
        {
            new Vector3((-1*Mathf.Sqrt(3)), 1, 0),
            new Vector3((1*Mathf.Sqrt(3)), -1, 0),
            new Vector3(0, -1, 0),
     
        };

    // Use this for initialization
    void Start () {
	
	}

    private void OnEnable()
    {
        GetComponent<PressGesture>().Pressed += pressedHandler;
    }

    private void OnDisble()
    {
        GetComponent<PressGesture>().Pressed -= pressedHandler;
    }
    private void pressedHandler(object sender, System.EventArgs e)
    {
        for (int i = 0; i < 3; i++)
        {
            var obj = Instantiate(sardine) as GameObject;
            var minis = obj.transform;
            minis.parent = transform.parent;
            //minis.name = "Sardine";
            minis.position = transform.TransformPoint(directions[i]/4);
            //minis.GetComponent<Rigidbody2D>().AddForce(Power * Random.insideUnitSphere, ForceMode2D.Impulse);
           
        }
        Destroy(gameObject);
    }
    
    // Update is called once per frame
    void Update () {
	
	}
}
