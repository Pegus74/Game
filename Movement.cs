using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private float move;
    private Rigidbody2D body;
    private bool m_FacingRight = true;
    private Animator animator;
    

    void Start()
    {
        body = GetComponent<Rigidbody2D>(); 
        animator = GetComponent<Animator>();
        
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");

        body.velocity = new Vector2(move * speed, body.velocity.y);

        if (move != 0) 
        {
            animator.SetBool("IsRunning", true);
           
        }
        else
        {
            animator.SetBool("IsRunning", false); 
        }

        if (move > 0 && !m_FacingRight)
        {
            Flip();
        }
        else if (move < 0 && m_FacingRight)
        {
            Flip();
        }

        


    }

    private void Flip()
    {
        m_FacingRight = !m_FacingRight;
        transform.Rotate(0f, 180f, 0f);
    }
}