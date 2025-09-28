using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Cube : MonoBehaviour
{
    private bool drop = false;

    private float x, y, z;   
    private Vector3 startPosition;
    public  int result;
    public bool abandoned = false;
    private Rigidbody rB;
    private System.Random variableRandomness = new System.Random();

    
    private bool isGrounded = false;
    private string ChecedZone = "ChecedZone";

    private void Awake()
    {
        rB = GetComponent<Rigidbody>();
        startPosition = transform.position;
        rB.useGravity = false;
    }

    private void Update()
    {
        if (Keyboard.current.anyKey.isPressed)
        {
            ThrovDice();
        }
    }

    private void FixedUpdate()
    {
        while (drop && !isGrounded && CheckVelocityStopped())
        {            
            isGrounded = true;
        }
    }

    private void ThrovDice()
    {
        if (!abandoned && !isGrounded)
        {
            rB.useGravity = true;
            drop = true;
          
            isGrounded = false;           
            rB.AddTorque(new Vector3(
                variableRandomness.Next(20, variableRandomness.Next(21, 130)),
                variableRandomness.Next(10, variableRandomness.Next(11, 101)),
                variableRandomness.Next(9, variableRandomness.Next(10, 25)))
            );
            rB.AddForce(Vector3.right * variableRandomness.Next(0, 5), ForceMode.Impulse);
        }
    }


    private bool CheckVelocityStopped()
    {
        return rB.linearVelocity.magnitude < 0.1f && rB.angularVelocity.magnitude < 0.1f;
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.gameObject.CompareTag("1"))
        {
            Debug.Log("Земля");
        }
        if (other.gameObject.CompareTag("1"))
        {
            Debug.Log("1");
        }
        else if (other.gameObject.CompareTag("2"))
        {
            Debug.Log("2");
        }
        else if (other.gameObject.CompareTag("3"))
        {
            Debug.Log("3");
        }
        else if (other.gameObject.CompareTag("4"))
        {
            Debug.Log("4");
        }
        else if (other.gameObject.CompareTag("5"))
        {
            Debug.Log("5");
        }
        else if (other.gameObject.CompareTag("6"))
        {
            Debug.Log("6");
        }

    }
}
