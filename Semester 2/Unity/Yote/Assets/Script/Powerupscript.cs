using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerupscript : MonoBehaviour {

    public Character character;
    public Character2 character2;
    public float timer = 0f;
    public float timer2 = 0f;
    public float teleporttimer = 0f;
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        teleporttimer += Time.deltaTime;
        if (timer >= 8)
        {
            character.rbody.mass = 1;
        }
        if (timer2 >= 8)
        {
            character2.rbody.mass = 1;            
        }
        if (teleporttimer >= 10)
        {
            transform.position = new Vector3(Random.Range(2,-2),Random.Range(1,-1), 1);
            teleporttimer = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            transform.position = new Vector3(4, 4, 0);
            character.rbody.mass = 300;
            timer = 0;            
        }
        if (collision.gameObject.tag == "Character2")
        {
            transform.position = new Vector3(4, 4, 0);
            character2.rbody.mass = 300;
            timer2 = 0;
        }
        if (collision.gameObject.tag == "Platform")
        {
            transform.position = new Vector3(Random.Range(2, -2), Random.Range(1, -1), 1);
        }
    }
}
