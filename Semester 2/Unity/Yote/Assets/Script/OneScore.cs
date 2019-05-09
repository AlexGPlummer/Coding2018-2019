using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneScore : MonoBehaviour {

    public Text Score;
    public int playerOneScore;
    Camera maincam;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = playerOneScore.ToString();
        if (playerOneScore == 5)
        {

        }
    }
}
