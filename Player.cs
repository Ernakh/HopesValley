using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick moveJoystick;
    private Rigidbody rb;
    private float moveH, moveV, speedMove = 5;
    public GameObject uiMassager;
    Animator animPerso;
   
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animPerso = GetComponent<Animator>();
    }
    
    void Update()
    {
        movePlayer();
    }
    
    void movePlayer()
    {
        moveH = moveJoystick.Horizontal;
        moveV = moveJoystick.Vertical;
        Vector3 dir = new Vector3(moveH, 0, moveV);
        rb.velocity = new Vector3(moveH * speedMove, rb.velocity.y, moveV * speedMove);
        if (dir != Vector3.zero)
        {
           
            animPerso.SetBool("Walk", true);
            transform.LookAt(transform.position + dir);
        }
        else
        {
            
            animPerso.SetBool("Walk", false);
        }

    }
    
}
