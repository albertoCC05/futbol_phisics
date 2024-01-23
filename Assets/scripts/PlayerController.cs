using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed;
    [SerializeField] private float rotateSpeed;
    private float horizontalInput;
    private float verticalIInput;
    private Rigidbody playerRigidboddy;
    private float forcePlayer = 8;
    

    private void Start()
    {
        playerRigidboddy = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalIInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalIInput * playerSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * Time.deltaTime * horizontalInput * rotateSpeed);

        
        

    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Rigidbody enemyRigidbody = other.gameObject.GetComponent<Rigidbody>();
            Vector3 direction = other.transform.position - transform.position;
            other.rigidbody.AddForce(direction * forcePlayer, ForceMode.Impulse);
        }
    }
}
