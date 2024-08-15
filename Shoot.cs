using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab; // Prefab của viên đạn
    public float bulletSpeed = 10f; // Tốc độ di chuyển của viên đạn
    public float fireRate = 0.5f; // Tốc độ bắn (giây/lần)
    private float nextFireTime = 0f; // Thời gian bắn tiếp theo

    private void Update()
    {
        // Kiểm tra xem người dùng có ấn chuột trái không
        if (Input.GetButtonDown("Fire1") && Time.time >= nextFireTime)
        {
            FireBullet();
            nextFireTime = Time.time + fireRate; // Cập nhật thời gian bắn tiếp theo
        }
    }

    private void FireBullet()
    {
        // Tạo một viên đạn mới tại vị trí và hướng của vũ khí
        GameObject bulletObject = Instantiate(bulletPrefab, transform.position, transform.rotation);
        Rigidbody2D bulletRigidbody = bulletObject.GetComponent<Rigidbody2D>();
        bulletObject.transform.Rotate(0f, 0f, 280f); // Xoay viên đạn 90 độ

        // Đẩy viên đạn về phía trước
        bulletRigidbody.velocity = bulletObject.transform.up * bulletSpeed;
    }
}