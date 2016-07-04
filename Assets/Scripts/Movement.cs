using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

    // Use this for initialization

    private Rigidbody2D mybody = null;
    public Vector2 direction = Vector2.zero;

    //private Vector2 startPosition = Vector2.zero;
    public float speed = 0.5f;
    //public float frequency = 5.0f;
    //public float amplitude = 1.0f;

    //private float timer = 0;
    //public Vector2 endPosition = Vector2.zero;

	void Start ()
    {
        mybody = transform.GetComponent<Rigidbody2D>();
        direction = Vector2.up;

        //startPosition = this.gameObject.transform.position;
        //endPosition = endPosition + startPosition;
	}
	
	// Update is called once per frame

    void FixedUpdate()
    {
        //direction = new Vector2(Mathf.Sin(Time.time * frequency) * amplitude , 1);
        mybody.MovePosition((Vector2)transform.position + direction * speed * Time.deltaTime);
    }

	void Update ()
    {
        

	}
}
