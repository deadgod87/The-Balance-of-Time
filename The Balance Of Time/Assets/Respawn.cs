using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

    public GameObject respawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.transform.position = respawnPoint.transform.position;
        }
    }
}
