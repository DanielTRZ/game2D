using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask WhatIsGround;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, jumpHeight);
            Debug.Log("W gore");
        }

        //if (Input.GetKey(KeyCode.DownArrow))
        // {
        //   GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
        //  Debug.Log("W gore");
       //  }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            Debug.Log("W prawo");
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            Debug.Log("W lewo");
        }

    }
}