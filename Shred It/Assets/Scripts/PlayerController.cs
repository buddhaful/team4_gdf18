﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {
  public float speed = 5f;
  public float jumpSpeed = 8f;
  private float movement = 0f;
  private Rigidbody2D rigidBody;
  private int count;
  public Text countText;
  private GameManagerScript GMS;
  
  // Use this for initialization
  void Start () {
    rigidBody = GetComponent<Rigidbody2D> ();
    
    GMS = GameObject.Find ("GameManager").GetComponent<GameManagerScript> ();

      //Initialize count to zero.
      count = 0;

      //Call our SetCountText function which will update the text with the current value for count.
      SetCountText ();
  }
  
  // Update is called once per frame
  
  void Update () {
    if (GMS.counterDownDone == true) { 
    movement = Input.GetAxis ("Horizontal");
    if (movement > 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    }
    else if (movement < 0f) {
      rigidBody.velocity = new Vector2 (movement * speed, rigidBody.velocity.y);
    } 
    else {
      rigidBody.velocity = new Vector2 (0,rigidBody.velocity.y);
    }
    if(Input.GetButtonDown ("Jump")){
      rigidBody.velocity = new Vector2(rigidBody.velocity.x,jumpSpeed);
    }
  }
  }
   //OnTriggerEnter2D is called whenever this object overlaps with a trigger collider.
    void OnTriggerEnter2D(Collider2D other) 
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("PickUp"))
                {
                     other.gameObject.SetActive(false);
                     
                      //Add one to the current value of our count variable.
                      count = count + 1;

                      //Update the currently displayed count by calling the SetCountText function.
                      SetCountText ();
                }
    }
    //This function updates the text displaying the number of objects we've collected and displays our victory message if we've collected all of them.
    void SetCountText()
    {
        //Set the text property of our our countText object to "Count: " followed by the number stored in our count variable.
        countText.text = "Score: " + count.ToString ();
    }
}