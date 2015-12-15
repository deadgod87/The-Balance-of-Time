using UnityEngine;
using System.Collections;

public class PlayerFollow : MonoBehaviour {

    public GameObject player;

    public float cameraZDist = 3f;
    public float cameraYdist = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        FollowPlayer();
	}

    void FollowPlayer()
    {
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + cameraYdist, player.transform.position.z -cameraZDist);
    }
}
