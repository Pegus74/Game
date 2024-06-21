using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private Animator animator;

    void Start()
    {
       
        animator = GetComponent<Animator>(); 
    }
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           

            Shoot();
            animator.SetBool("IsRunning", false);
            animator.SetBool("IsShooting", true);
        }
        if (Input.GetButtonDown("Fire2") )
        {

          
            animator.SetBool("IsShooting", false);
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
