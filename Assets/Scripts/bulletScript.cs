﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour {

    public float speed = 10f;
    Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    void Update()
    {
        //set active
        rb.velocity = transform.up * speed;
    }

    void OnBecameInvisible()
    {
        gameObject.SetActive(false);
    }
}
