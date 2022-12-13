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
    private bool grouned;
    public bool doubleJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    void FixedUpdate()
    {
        grouned = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, WhatIsGround);
    }
    // Update is called once per frame
    void Update()
    {
        if (grouned)
            doubleJump = false;

        if (Input.GetKeyUp(KeyCode.UpArrow) && grouned)
        {
            //metoda ->jump
            Jump();
           
            //  GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
            Debug.Log("W gore");
        }

        //jump
        if (Input.GetKeyUp(KeyCode.UpArrow) && !grouned && !doubleJump)
        {
            //metoda ->jump
            Jump();
            doubleJump = true;
         //   GetComponent<Rigidbody2D> ().velocity = new Vector2 (0, jumpHeight);
            Debug.Log("W gore");
        }

        // if (Input.GetKey(KeyCode.DownArrow))
        //  {
        //    GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.x);
        //   Debug.Log("W gore");
        //  }

        //move to the right
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            Debug.Log("W prawo");
        }
        //move to the left
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            Debug.Log("W lewo");
        }

    } 
       void Jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, jumpHeight);
    }

}
