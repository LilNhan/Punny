using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private Vector3 targetPosition;
    public Transform mainCharacter; // Tham chiếu đến Main Character
    public float rotationSpeed = 5f; // Tốc độ xoay của vũ khí

    private void FixedUpdate()
    {
        
        MoveWeaponWithCharacter();
        
    }

    

    void MoveWeaponWithCharacter()
    {

        transform.position = new Vector3(mainCharacter.position.x+0.5f, mainCharacter.position.y, transform.position.z);
    }


}