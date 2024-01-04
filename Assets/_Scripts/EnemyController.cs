using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private float movementSpeed; 
    
    private CharacterController characterController;

    
    private void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (playerTransform != null)
        {
            var direction = playerTransform.position - transform.position;
            direction.y = 0f; 
            var moveVector = direction.normalized * movementSpeed * Time.deltaTime;
            characterController.Move(moveVector);
        }
    }
    
}
