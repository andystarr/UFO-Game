using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;         //Floating point variable to stor the player's speed.
    private Rigidbody2D rb2d;   // Store a referene to the Rigidbody 2d component.

    // Use this for initialization.
    private void Start()
    {
        //Get and store a reference to the Ridgidboy2d component so that we can access it it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate.
    private void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");
        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Ust the tow stored floats to create a new Vector2 varible movement
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Ridgidbody2d rb2d with movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
        Debug.Log(movement);
    }



}
