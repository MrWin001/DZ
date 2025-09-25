using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.PlayerLoop;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Rigidbody rigidbody;
    private bool hasLanded;
    private bool abandoned;
    private Vector3 initPOsition;   
    private System.Random variableRandomness = new System.Random();
    private Vector3 direction = Vector3.zero;
    private int Score;
    private Keyboard keyboard;
    private List<int> pointsCube;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        initPOsition = transform.position;
        rigidbody.useGravity = false;
    }

    // Update is called once per frame
    private void Update()
    {
        
        switch (Keyboard.current.anyKey.isPressed)
        {
            case true:
                Roll();
                break;

            default:
                break;
        }
            
    }
    private void Roll()
    {
        if (!abandoned && !hasLanded)
        {          
            abandoned = true;
            rigidbody.useGravity = true;
            rigidbody.AddTorque(
                new Vector3(
                variableRandomness.Next(20, variableRandomness.Next(20, 250)),
                variableRandomness.Next(10, variableRandomness.Next(20, 100)),
                variableRandomness.Next(9, variableRandomness.Next(20, 275)))
                );
            rigidbody.AddForce(Vector3.right * variableRandomness.Next(0, 15), ForceMode.Impulse);
        }
    }
    private void Resets()
    {
        rigidbody.position = initPOsition;
        abandoned = false;
        hasLanded = false;
        rigidbody.useGravity = false;
    }
    private void ReRoll(bool hasLanded,Rigidbody rigidbody)
    {
        if (hasLanded == true && rigidbody.useGravity == false && rigidbody.IsSleeping())
        {
            Resets();
            Roll();
        }
    }
}
