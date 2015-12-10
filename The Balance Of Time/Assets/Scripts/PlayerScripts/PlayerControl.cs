using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour {

    //Player movement Speed
    public float moveSpeed = 3.0f;
    //Player Max jump height
    public float jumpHeight = 3.0f;
    //Player max jump speed
    public float jumpSpeed = 1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        MovementControl();
	
	}

    //Handles the movement functions for the player
    void MovementControl()
    {
        //references the horizontal (left/right) input by the player 
        float h = Input.GetAxisRaw("Horizontal");
        //Checks if a direction is being inputted
        if(h != 0)
        {
            //moves the player in the right direction based on input
            transform.position += transform.right * moveSpeed * Time.deltaTime;
        }

        //Vector that holds current player movement
        Vector3 NextDir = new Vector3(0, 0, h);
        //checks if player is moving
        if (NextDir != Vector3.zero)
        {
            //Rotates player to proper direction based on movement input
            transform.rotation = Quaternion.LookRotation(NextDir);
        }


        if(Input.GetButtonDown("Jump"))
        {
            transform.position += transform.up * jumpHeight * jumpSpeed * Time.deltaTime;
        }
    }
}
