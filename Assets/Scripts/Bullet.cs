using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    [SerializeField] private GameObject BulletDestroyEffect;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<Enemy>().TakeDamage(damage);

            GameObject effect = Instantiate(BulletDestroyEffect, transform.position, Quaternion.identity);
            Destroy(effect, 0.25f);
            Destroy(gameObject);
        }
        else if (collision.CompareTag("Barrier"))
        {
            Destroy(gameObject);
        }
    }
}
