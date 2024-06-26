using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D body;
    public GameObject impactEffect;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = transform.right * speed;

    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
         Enemy enemy = hitInfo.GetComponent<Enemy>();
         if (enemy != null)
         {
             enemy.TakeDamage(damage);
            Instantiate(impactEffect, transform.position, transform.rotation);

            Destroy(gameObject);
        }

       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
