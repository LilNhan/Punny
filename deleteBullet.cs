using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete : MonoBehaviour
{
    public float lifetime = 2f; // Thời gian sống của viên đạn
    private float spawnTime; // Thời gian tạo ra viên đạn

    private void Start()
    {
        spawnTime = Time.time;
    }

    private void Update()
    {
        // Kiểm tra xem viên đạn đã sống được bao lâu
        if (Time.time - spawnTime >= lifetime)
        {
            if (gameObject.transform.parent != null)
            {
                Destroy(gameObject.transform.parent.gameObject);
            }
        }
    }
}