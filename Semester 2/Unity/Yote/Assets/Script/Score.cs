using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour {
    public OneScore Score1;
    public TwoScore Score2;
    public float timer = 900f;
    public float timer2 = 900f;
    public bool onPlatform2 = true;
    public bool onPlatform = true;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime;
        timer2 += Time.deltaTime;
        if (timer >= 4 && onPlatform == false) 
        {
            timer = 0;
            Score1.playerOneScore++;
        }
        if (timer2 >= 4 && onPlatform2 == false && timer2 <= 900)
        {
            timer2 = 0;
            Score2.playerTwoScore++;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            timer = 0;
            onPlatform = false;
        }
        if (collision.gameObject.tag == "Character2")
        {
            timer2 = 0;
            onPlatform2 = false;
        }
    }
}
