﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public Vector3 velocity = new Vector3(0, 0, 0);
    public float timer = 0f;
    // Use this for initialization
    void Start () {
        color();
        velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
    }
    [SerializeField]
    float speed = 4f;   
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            color();
            timer = 0;
        }
        transform.position += velocity * Time.deltaTime * speed;
        if (transform.position.x < -7.5)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(-7.5f, transform.position.y, 0);
            color();
        }
        if (transform.position.x > 7.5)
        {
            velocity = Vector3.Reflect(velocity, Vector3.right);
            transform.position = new Vector3(7.5f, transform.position.y, 0);
            color();
        }
        if (transform.position.y > 5)
        {
            velocity = Vector3.Reflect(velocity, Vector3.down);
            transform.position = new Vector3(transform.position.x, 5f, 0);
            color();
        }
        if (transform.position.y < -5f)
        {
            velocity = Vector3.Reflect(velocity, Vector3.up);
            transform.position = new Vector3(transform.position.x, -5, 0);
            color();
        }
    }
    public void color()
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    
}
