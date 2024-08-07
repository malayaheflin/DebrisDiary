using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb; // why is this public
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if(!hitInfo.gameObject.CompareTag("Player"))
        {
            Debug.Log(hitInfo.name);
            Destroy(gameObject);
        }
    }
}
