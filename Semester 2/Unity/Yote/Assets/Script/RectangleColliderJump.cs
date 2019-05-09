using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RectangleColliderJump : MonoBehaviour {

    public Character character;
    public Score timer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Platform" || collision.gameObject.tag == "PointPlatform")
        {
            character.isjump = false;
        }
        if (collision.gameObject.tag == "Platform")
        {
            timer.onPlatform = true;
        }
    }
}
