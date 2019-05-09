using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoScore : MonoBehaviour {

    public Text Score;
    public int playerTwoScore;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Score.text = playerTwoScore.ToString();
	}
}
