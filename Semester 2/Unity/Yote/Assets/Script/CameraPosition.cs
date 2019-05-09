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
        timer += Time.deltaTime;
        if (timer >= 8 && timer < 900)
        {
            SceneManager.LoadScene(sceneLoad);
        }
        if (Score1.playerOneScore == 5)
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(-10, 1, 1);
            GameObject.Find("Character").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Character2").transform.position = new Vector3(0, 0, 0);
            timer = 0;
        }
        if (Score2.playerTwoScore == 5)
        {
            GameObject.Find("Main Camera").transform.position = new Vector3(10, 1, 1);
            GameObject.Find("Character").transform.position = new Vector3(0, 0, 0);
            GameObject.Find("Character2").transform.position = new Vector3(0, 0, 0);
        }
    }
}
