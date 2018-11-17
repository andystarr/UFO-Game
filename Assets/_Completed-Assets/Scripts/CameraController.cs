using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start ()
    {

        //transform by itself represents the gameobject it's attached to, in this case the camera.
        offset = transform.position - player.transform.position;
		
	}

    //LateUpdate is called once per frame but is guaranteed to run last
    void LateUpdate ()
    {
        //move the camera relative to the player with offset
        transform.position = player.transform.position + offset;
		
	}
}
