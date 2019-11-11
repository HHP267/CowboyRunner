using UnityEngine;
using System.Collections;

public class Animate : MonoBehaviour {

    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Obstacle")
        {
            anim.Play("Idle");
        }
    }
    private void OnCollisionExit2D(Collision2D target)
    {
        if (target.gameObject.tag == "Obstacle")
        {
            anim.Play("Run");
        }
    }
}
