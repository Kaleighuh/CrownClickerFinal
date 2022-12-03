using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/*public class playerMovement : MonoBehaviour
{
    public UnityEvent moveNextScene;
    public float movementSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    public Animator animator;
    private float horizontalMove = .50f;
    private float verticalMove = .05f;

    public Joystick joystick;

    void Update()
    {
        if (joystick.Horizontal >= .2f)
        {
            horizontalMove = movementSpeed;
        }
        else if (joystick.Horizontal <= .2f)
        {
            horizontalMove = -movementSpeed;
        }
        else
        {
            horizontalMove = 0f;
        }

        movement.x = Input.GetAxisRaw("Horizontal"); //input
        movement.y = Input.GetAxisRaw("Vertical");
        
    }


    animator.SetFloat("Horizontal", movement.x);
    animator.SetFloat("Vertical", movement.y);
    animator.SetFloat("Speed", movement.sqrMagnitude);
    void Start()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.deltaTime);
    }

    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
    }

}*/
    
