using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    private float RotateSpeed;
    private float speed;
    private Rigidbody2D rb;
    [SerializeField] private GameObject DestroyEffect;
    [SerializeField] private int damage;


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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            collision.collider.GetComponent<HealthSystem>().TakeDamage(damage);

            GameObject effect = Instantiate(DestroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.50f);
            Destroy(gameObject);
        }
    }

}
