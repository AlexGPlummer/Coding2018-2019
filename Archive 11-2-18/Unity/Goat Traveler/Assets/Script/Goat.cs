using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goat : MonoBehaviour {
    Rigidbody2D rbody;

	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
        AudioManager.Instance.PlayOneShot(SoundEffect.Moosic);
    }
    [SerializeField]
    float speed = 4f;
    Vector3 velocity = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y < 12)
            {
                transform.position += .5f * Vector3.up * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y > -12)
            {
                transform.position += .5f * Vector3.down * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.x < 19.75f)
            {
                transform.position += .5f * Vector3.right * Time.deltaTime * speed;
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.x > -19.75f)
            {
                transform.position += .5f * Vector3.left * Time.deltaTime * speed;
            }
        }
    }       
}


