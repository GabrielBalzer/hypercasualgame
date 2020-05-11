﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField]
    //private bool moving;
    private Vector3 velocity;

    private void FixedUpdate()
    {
        transform.position += (velocity * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TedPlayer ted = new TedPlayer();
        if(collision.transform.name == "Player")
        {
            Destroy(gameObject);
            return;
        }
        Platform01 platform01 = collision.collider.GetComponent<Platform01>();
        if(platform01 != null)
        {
            return;
        }

        if(collision.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
        }
    }
}
