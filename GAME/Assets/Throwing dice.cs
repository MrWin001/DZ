using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.UI;

public class ThrowingDice: MonoBehaviour
{
    private bool hasLanded;
    private bool abandoned;
    private bool isTrowing = true;
    private Rigidbody rigidbody;
    private System.Random variableRandomness = new System.Random();
    
    private Vector3 initPOsition;   
    private static Vector3 diceVelocity;

    public static Vector3 DiceVelocity
    {
        get { return diceVelocity; }
        set 
        {
            if (value == null)
            {

            }
            else
            {
                diceVelocity = value;
            }            
        }
    }


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        initPOsition = transform.position;
        rigidbody.useGravity = false;
    }
    
    private void Update()
    {      
        if (Keyboard.current.anyKey.isPressed && isTrowing == true)
        {           
            Roll();            
        }            
    }
    private void Roll()
    {
        isTrowing = false;      
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

    //private void Resets()
    //{
    //    rigidbody.position = initPOsition;
    //    abandoned = false;
    //    hasLanded = false;
    //    rigidbody.useGravity = false;
    //}

    //private void ReRoll(bool hasLanded,Rigidbody rigidbody)
    //{
    //    if (hasLanded == true && rigidbody.useGravity == false && rigidbody.IsSleeping())
    //    {
    //        Resets();
    //        Roll();
    //        isTrowing = true;
    //    }
    //}
}
