using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public Animator animator;
    public List<Vector3> teleportLocations = new List<Vector3>();
    float jump = 3;
    float speed = 2;
    public bool isjump = true;


    Vector3 velocity = new Vector3(0, 0, 0);
    public Rigidbody2D rbody;
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
    [SerializeField]
    bool Up = false;
    bool Left = false;
    bool Right = false;
    // Update is called once per frame
    void Update()
    {
        velocity = rbody.velocity;
        if (Input.GetKeyDown(KeyCode.W) && isjump == false)
        {
            velocity += Vector3.up * jump;
            AudioManager.Instance.PlayOneShot(SoundEffect.Jump);
            isjump = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            Left = true;
            animator.SetBool("Left", true);
            velocity -= Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool("Left", false);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Right = true;
            animator.SetBool("Right", true);
            velocity += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            animator.SetBool("Right", false);
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 5), velocity.y, 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -1f, 1f), Mathf.Clamp(velocity.y, -4f, 4f), 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Character")
        {
            rbody.mass = 3;
        }
    }
}
