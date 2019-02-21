using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    Rigidbody2D rbody;
    [SerializeField]
    GameObject ballPrefab;

    // Use this for initialization
    void Start()
    {
        Random rand = new Random();
        rbody = GetComponent<Rigidbody2D>();
    }
    [SerializeField]
    float speed = 3f;
    Vector3 velocity = new Vector3(0, 0, 0);
    // Update is called once per frame
    void Update()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            if (transform.position.y < 5)
            {
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z - 200 * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (transform.position.y > -5)
            {
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 200 * Time.deltaTime);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            velocity += LookAtDirection(transform.eulerAngles.z);
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= LookAtDirection(transform.eulerAngles.z);
        }
        velocity.Normalize();

        transform.position += velocity * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newball = Instantiate(ballPrefab);
            newball.transform.position = transform.position;
            newball.GetComponent<ball>().velocity = LookAtDirection(transform.eulerAngles.z);
        }

    }
    void Movementarrows()
    {
        velocity = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 5)
            {
                velocity += Vector3.up;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -5)
            {
                velocity += Vector3.down;
            }
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 7.5f)
            {
                velocity += Vector3.right;
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -7.5f)
            {
                velocity += Vector3.left;
            }
        }
    }
    public Vector3 LookAtDirection(float eulerAngles2)
    {
        return new Vector3(Mathf.Cos(eulerAngles2 * Mathf.Deg2Rad), Mathf.Sin(eulerAngles2 * Mathf.Deg2Rad), 0);
    }
    
}
