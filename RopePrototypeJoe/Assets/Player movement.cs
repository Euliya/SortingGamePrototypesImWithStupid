using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Rigidbody2D rb;
    float x;
    float y;
    public float speed;
    public bool isP2;
    Vector3 direction;
    // Update is called once per frame
    void Update()
    {
        //still use the same input.get axis values however it is a step
        if (isP2)
        {
            x = Input.GetAxis("HorizontalP2");
            y = Input.GetAxis("VerticalP2");
            transform.position += new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
        }else
        {
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");
            transform.position += new Vector3(x * speed * Time.deltaTime, y * speed * Time.deltaTime);
        }
        //rb.AddForce(direction * speed);
    }

   
}