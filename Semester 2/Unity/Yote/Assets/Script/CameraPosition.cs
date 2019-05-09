using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CameraPosition : MonoBehaviour {

    public string sceneLoad;
    public float timer = 900f;
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
            Score1.playerOneScore = 6;
            timer = 0;
            //timer += Time.deltaTime;
        }
        if (Score2.playerTwoScore == 5)
        {
            Score2.playerTwoScore = 6;
            GameObject.Find("Main Camera").transform.position = new Vector3(10, 1, 1);
            GameObject.Find("Character").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Character2").transform.position = new Vector3(0, 0, 0);
            timer = 0;
            //timer += Time.deltaTime;
        }
        timer += Time.deltaTime;
        if (timer >= 8 && timer < 900)
        {
            SceneManager.LoadScene(sceneLoad);
        }
    }
}
