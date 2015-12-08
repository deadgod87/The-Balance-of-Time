using UnityEngine;
using System.Collections;

public class SmallTransitionZone : MonoBehaviour {

    public GameObject transitionEndUp;
    public GameObject transitionEndDown;

    public bool canGoUp = false;
    public bool canGoDown = false;

    private bool canTransition = false;

    private GameObject player;

	// Use this for initialization
	void Start () {

        player = GameObject.FindGameObjectWithTag("Player");
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        Transition();
	}

    void Transition()
    {
        if (canTransition)
        {
            if (canGoUp)
            {
                if (Input.GetButtonDown("Up"))
                {
                   player.transform.position = transitionEndUp.transform.position;
                }
            }

            if (canGoDown)
            {
                if (Input.GetButtonDown("Down"))
                {
                    player.transform.position = transitionEndDown.transform.position;
                }
            }
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            canTransition = true;
        }
    }
}
