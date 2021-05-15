using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    public float jumpVelocity = 20;
    private bool isGrounded;
    private float groundHeight = 1;

    private Animator playerAnimation;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimation = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && isGrounded) {
            rb.velocity = Vector2.up * jumpVelocity;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && !isGrounded) {
            rb.velocity = Vector2.down * (jumpVelocity/2);
        }
        
        if (rb.position.y <= groundHeight) {
            isGrounded = true;
        }
        else {
            isGrounded = false;
        }

        if (!isGrounded) {
            playerAnimation.SetBool("Jumping", true);
        } else {
            playerAnimation.SetBool("Jumping", false);
        }
    }
}
