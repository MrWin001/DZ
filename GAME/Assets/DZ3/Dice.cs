using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.VFX;
using static UnityEngine.Rendering.DebugUI;

public class Dice : MonoBehaviour
{
    private bool isAbandoned = false;
    private TrigersScripts triggerScript;
    private Vector3 startPosition;
    private Rigidbody rB;

    [SerializeField] private Global globalValue;   
    public System.Random variableRandomnes { get; set; }
    public bool isGrounded { get; set; } = false;
    [SerializeField]
    public Rigidbody RB
    {
        get { return rB; }
        set
        {
            if (value == null) Debug.LogWarning($"Dise == null");
            rB = value;
        }
    }

    public Vector3 StartPosition
    {
        get { return startPosition; }
        set
        {
            if (value == null) Debug.LogWarning($"StartPosition == null");
            startPosition = value;
        }
    }

    private void Awake()
    {      
        rB = GetComponent<Rigidbody>();
        startPosition = rB.transform.position;
        triggerScript = GetComponent<TrigersScripts>();
        rB.useGravity = false;
        if (globalValue == null) globalValue = FindObjectOfType<Global>();
        if (variableRandomnes == null) variableRandomnes = new System.Random();
    }

    private void FixedUpdate()
    {
        isGrounded = false;
        if (Keyboard.current.anyKey.isPressed)
        {           
            ThrovDice();                             
        }
    }

    private void ThrovDice()
    {
        if (!isAbandoned && !isGrounded)
        {
            rB.useGravity = true;           
            rB.AddTorque(new Vector3(
                variableRandomnes.Next(20, variableRandomnes.Next(21, 30)),
                variableRandomnes.Next(10, variableRandomnes.Next(11, 20)),
                variableRandomnes.Next(9, variableRandomnes.Next(10, 25)))
            );
            rB.AddForce(Vector3.right * variableRandomnes.Next(0, 5), ForceMode.Impulse);           
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerScript != null)
        {
            triggerScript.SideCollider = other;
            isGrounded = true;
            Debug.Log($"Dise on plase");
        }
    }
}
