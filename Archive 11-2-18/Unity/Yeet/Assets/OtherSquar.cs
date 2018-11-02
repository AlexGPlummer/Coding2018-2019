using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherSquar : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        Random rand = new Random();

        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }
    [SerializeField]
    float speed = 7f;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += .5f * Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += .5f * Vector3.down * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += .5f * Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += .5f * Vector3.left * Time.deltaTime * speed;
        }
    }
}
