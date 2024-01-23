using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    private Rigidbody enemyRigidbody;
    [SerializeField] private float enemySpeed;
    [SerializeField] private GameObject playerGoalReference;
    private Vector3 moveDirection;


    private void Start()
    {
        enemyRigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        moveDirection = playerGoalReference.transform.position - transform.position;
        enemyRigidbody.AddForce(moveDirection * enemySpeed);

        
    }
}
