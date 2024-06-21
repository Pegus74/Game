using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patroling : MonoBehaviour
{
    public GameObject point1;
    public GameObject point2;
    private Rigidbody2D rb;
    private Animator animation;
    private Transform currentPoint;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animation = GetComponent<Animator>();
        currentPoint = point2.transform;
        animation.SetBool("isRunning", true);


    }

    // Update is called once per frame
    void Update()
    {
        Vector2 point= currentPoint.position - transform.position;
        if(currentPoint==point2.transform)
        {
            rb.velocity = new Vector2(speed, 0);
        }
        else 
        {
            rb.velocity = new Vector2(-speed, 0);
        }

        if(Vector2.Distance(transform.position,currentPoint.position) < 0.5f && currentPoint == point2.transform      )     
        {
            flip();
            currentPoint = point1.transform;

        }
        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == point1.transform)
        {
            flip();
            currentPoint = point2.transform;

        }
    }
    private void flip()
    {
        Vector3 localScale =transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(point1.transform.position, 0.5f);
        Gizmos.DrawWireSphere(point2.transform.position, 0.5f);
        Gizmos.DrawLine(point1.transform.position, point2.transform.position);

    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
       Enemy hero = hitInfo.GetComponent<Enemy>();
        if (hero != null)
        {
            Debug.Log(hitInfo.name);
        }


    }

}
