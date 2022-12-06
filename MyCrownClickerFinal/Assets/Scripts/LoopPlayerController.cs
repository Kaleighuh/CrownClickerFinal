using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopPlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private float moveVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveVelocity = 0f;
        //How to get the player to move
        if(Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }
        if(Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }
        rb.velocity = new Vector2(moveVelocity,rb.velocity.y);
    }

    void Update()
    {
        
    }

}
