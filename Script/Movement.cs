using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;
    public float maxSpeed = 10f;
    public float accelerationRate = 2f;
    public float jumpForce = 10f;
    public float groundCheckRadius = 0.5f;
    public LayerMask groundLayer;
    private float velocity;
    private Rigidbody2D rb;
    private bool isFacingRight = true;
    private bool isGrounded = false;
    public float gravity = -20f;
    private float jumpTime = 0.5f;
    private float currentJumpTime = 0f;
    private float raycastDistance = 1.1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Tăng tốc độ khi ấn Shift
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = Mathf.Clamp(speed * accelerationRate, 0f, maxSpeed);
        }
        else
        {
            speed = 5f;
        }

        // Di chuyển player
        float horizontal = Input.GetAxis("Horizontal");
        transform.position += new Vector3(horizontal * speed * Time.deltaTime, 0, 0);


        // Thay đổi hướng di chuyển
        if (horizontal < 0 && isFacingRight)
        {
            Flip();
        }
        else if (horizontal > 0 && !isFacingRight)
        {
            Flip();
        }
    } 
    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}