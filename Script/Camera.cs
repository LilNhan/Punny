using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public float cameraSpeed = 5f; // Tốc độ ban đầu của camera
    public float speedIncrement = 0.1f; // Mức tăng tốc độ mỗi frame

    private void Update()
    {
        // Di chuyển camera theo trục x
        transform.Translate(Vector3.right * cameraSpeed * Time.deltaTime);

        // Tăng tốc độ camera
        cameraSpeed += speedIncrement * Time.deltaTime;
    }
}