using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] private GameObject bullet;

    private float timeBtwShots;
    public float startTimeBtwShots;
    public float BulletSpeed;

    private void Update()
    {

        if(timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                GameObject newBullet = Instantiate(bullet, transform.position, transform.rotation);
                Rigidbody2D newBulletRB = newBullet.GetComponent<Rigidbody2D>();
                newBulletRB.AddForce(transform.up * BulletSpeed, ForceMode2D.Impulse);

                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        
    }
}
