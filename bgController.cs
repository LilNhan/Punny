using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgController : MonoBehaviour
{
    public float scrollingSpeed = 0.5f; // Tốc độ cuộn nền
    public float repeatPointX = 10f; // Điểm lặp lại theo trục X

    private float startPositionX;
    private float endPositionX;
    private float backgroundWidth;

    private void Start()
    {
        // Lưu giá trị vị trí khởi đầu và kết thúc, cũng như chiều rộng của nền
        startPositionX = transform.position.x;
        backgroundWidth = GetComponent<SpriteRenderer>().bounds.size.x;
        endPositionX = startPositionX + backgroundWidth;
    }

    private void Update()
    {
        // Di chuyển nền sang trái
        transform.Translate(Vector3.left * scrollingSpeed * Time.deltaTime);

        // Kiểm tra nếu nền đã đi ra khỏi màn hình
        if (transform.position.x <= -backgroundWidth)
        {
            // Đặt lại vị trí của nền về phía bên phải của màn hình
            transform.position = new Vector3(endPositionX, transform.position.y, transform.position.z);
        }
    }
}