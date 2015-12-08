using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    public float moveSpeed = 3.0f;
    public float jumpHeight = 3.0f;
    public float jumpSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        MovementControl();
	
	}

    void MovementControl()
    {
        float h = Input.GetAxis("Horizontal");

        if(h > 0)
        {
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

        if (h < 0)
        {
            transform.position -= transform.right * moveSpeed * Time.deltaTime;
        }

        if(Input.GetButtonDown("Jump"))
        {
            transform.position += transform.up * jumpHeight * jumpSpeed * Time.deltaTime;
        }
    }
}
