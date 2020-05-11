﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using System;

public class woodbox : MonoBehaviour
{
    public float speed = 20.0f;
    private Rigidbody2D rb;
    private Vector2 screenBounds;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(-speed, 0);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < screenBounds.x * 2)
        {
            //Console.WriteLine(screenBounds.x + " " + screenBounds.y + " " + Screen.width + " " + Screen.height);   
            Destroy(this.gameObject);
        }
    }
}