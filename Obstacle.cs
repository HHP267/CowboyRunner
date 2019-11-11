using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

    private float speed = -3f;
    private Rigidbody2D mybody;
	// Use this for initialization
	void Start () {
        mybody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        mybody.velocity = new Vector2(speed, 0f);
	}
}
