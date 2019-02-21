using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public Vector3 velocity = new Vector3(0, 0, 0);
    public float timer = 0f;
    // Use this for initialization
    void Start () {
        //color();
        velocity = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        velocity.Normalize();
    }
    [SerializeField]
    float speed = 4f;
    GameObject ballPrefab;
    // Update is called once per frame
    void Update () {
        timer += Time.deltaTime;
        if (timer >= 2)
        {
            //color();
            timer = 0;
        }
    }
    public void color()
    {
        GetComponent<SpriteRenderer>().color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
    }

    public Transform originalObject;
    public Transform reflectedObject;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.right);
        }
    }

}
