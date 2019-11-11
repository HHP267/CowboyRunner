using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Jump : MonoBehaviour {

    [SerializeField]
    private AudioClip jumpClip;

    private Rigidbody2D mybody;
    private float jumpForce = 12f, forwardForce = 0f;
    private bool canJump;
    private Button jumpBtn;


	// Use this for initialization
	void Awake () {
        mybody = GetComponent<Rigidbody2D>();

        jumpBtn = GameObject.Find("Jump Button").GetComponent<Button>();
        jumpBtn.onClick.AddListener(() => PlayerJump());
	}
	
	// Update is called once per frame
	void Update () {
        if (Mathf.Abs(mybody.velocity.y) == 0)
        {
            canJump = true;
        }
	}

    public void PlayerJump() {

        if (canJump)
        {
            canJump = false;
            //AudioSource.PlayClipAtPoint(jumpClip, transform.position);

            if (transform.position.x < 0)
            {
                forwardForce = 1f;
            }
            else
            {
                forwardForce = 0f;
            }

            mybody.velocity = new Vector2(forwardForce, jumpForce);
        }
    }
}
//Player Jump






















