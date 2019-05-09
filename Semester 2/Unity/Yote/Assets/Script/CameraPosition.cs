using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPosition : MonoBehaviour {

    public OneScore Score1;
    public TwoScore Score2;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Score1.playerOneScore == 5)
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(-10, 1, 1);
            GameObject.Find("Character").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Character2").transform.position = new Vector3(0, 0, 0);
        }
        if (Score2.playerTwoScore == 5)
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(10, 1, 1);
            GameObject.Find("Character").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Character2").transform.position = new Vector3(0, 0, 0);
        }
    }
}
