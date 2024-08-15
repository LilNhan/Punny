using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 5f; // Lực nhảy
    public int maxJumpCount = 1; // Số lần nhảy tối đa

    private Rigidbody2D rb;
    private int jumpCount = 0; // Số lần nhảy hiện tại
    private bool isGrounded = false; // Kiểm tra xem player có đang ở trên mặt đất hay không
    private Animator anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        // Kiểm tra xem player có đang ấn phím nhảy không
        if (Input.GetButtonDown("Jump"))
        {
            // Nếu player đã ấn nhảy tối đa 2 lần hoặc đang ở trên mặt đất
            if (jumpCount < maxJumpCount || isGrounded)
            {
                // Tăng số lần nhảy và nhảy lên
                jumpCount++;
                rb.velocity = new Vector2(rb.velocity.x, jumpForce);

                // Chơi animation "Jump"
                anim.SetTrigger("Jump");
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Khi player tiếp xúc với mặt đất, đặt lại số lần nhảy về 0
        isGrounded = true;
        jumpCount = 0;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // Khi player rời khỏi mặt đất, đặt isGrounded về false
        isGrounded = false;
    }
}