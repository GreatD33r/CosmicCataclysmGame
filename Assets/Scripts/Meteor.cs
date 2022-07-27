using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private float RotateSpeed;
    private float speed;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        speed = Random.Range(-1, -3);
        RotateSpeed = Random.Range(1, 3);
    }
    private void Update()
    {
        
        rb.velocity = new Vector2(speed, 0);
        transform.Rotate(0.0f, 0.0f, RotateSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Deleter"))
        {
            Destroy(gameObject);
        }
    }
}
