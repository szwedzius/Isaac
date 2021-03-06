﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float speed;
    private bool canExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Exit")
        {
            canExit = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Exit")
        {
            canExit = false;
        }
    }


    //I use void update because even though its movement its regulated by fixed values rather than physics
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            this.transform.position = this.transform.position + new Vector3(0,speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = this.transform.position + new Vector3(0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = this.transform.position + new Vector3(-speed,0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = this.transform.position + new Vector3(speed,0);
        }
        if(Input.GetKey(KeyCode.E) && canExit)
        {
            Debug.Log("Exit");
            Destroy(this.gameObject);
        }
    }
}
