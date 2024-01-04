using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float mouseSense;
    [SerializeField] Transform player;
    

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    void Update()
    {
        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;
        
        Vector3 rotPlayer = player.rotation.eulerAngles;
        
        rotPlayer.x -= rotateY;
        rotPlayer.y += rotateX;
        
        float clampedXRotation;
        if (rotPlayer.x > 180)
        {
            clampedXRotation = rotPlayer.x - 360;
        }
        else
        {
            clampedXRotation = rotPlayer.x;
        }
        clampedXRotation = Mathf.Clamp(clampedXRotation, -90, 90);
        
        transform.rotation = Quaternion.Euler(clampedXRotation, rotPlayer.y, rotPlayer.z);
       
    }
}
