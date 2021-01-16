﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed;

    private Rigidbody2D rb;
    private Rigidbody2D rb2;
    private float moveDirectionHorizontal;
    private float moveDirectionVertical;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get inputs
        moveDirectionHorizontal = Input.GetAxis("Horizontal");
        moveDirectionVertical = Input.GetAxis("Vertical");
        

        //Move
        rb.velocity = new Vector2(moveDirectionHorizontal * moveSpeed, rb.velocity.y);
        rb2.velocity = new Vector2(moveDirectionVertical * moveSpeed, rb.velocity.x);
    }
}