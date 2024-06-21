using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 40;
    public Rigidbody2D body;
    public GameObject impactEffect;
    public PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        body.velocity = transform.right * speed;
        playerHealth = FindObjectOfType<PlayerHealth>();
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        
        if (hitInfo.gameObject.tag=="Player")
        {
            Destroy(gameObject);
            playerHealth.TakeDamage(damage);
        }

        Instantiate(impactEffect, transform.position, transform.rotation);
        Debug.Log(hitInfo.name);

       
    }
        // Update is called once per frame
        void Update()
        {
       
         }
}
