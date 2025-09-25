using UnityEngine;
using UnityEngine.InputSystem;

public class ThrowingDice : MonoBehaviour
{
    private bool hasLanded = false;
    private bool abandoned = false;
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
                return;
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
        if (Keyboard.current.anyKey.isPressed)
        {
            diceVelocity = rigidbody.linearVelocity;
            Roll();
        }
    }

    private void Roll()
    {
        diceVelocity = rigidbody.linearVelocity;       
        if (!abandoned && !hasLanded)
        {
            TextScripts.points = 0;
            abandoned = true;
            rigidbody.useGravity = true;
            rigidbody.AddTorque(
                new Vector3(
                variableRandomness.Next(20, variableRandomness.Next(20, 250)),
                variableRandomness.Next(10, variableRandomness.Next(20, 100)),
                variableRandomness.Next(9, variableRandomness.Next(20, 275)))
                );
            rigidbody.AddForce(Vector3.right * variableRandomness.Next(0, 15), ForceMode.Impulse);
            isTrowing = false;
        }       
    }

    //TODO
    //private void Reset()
    //{
    //    rigidbody.position = initPOsition;
    //    abandoned = false;
    //    hasLanded = false;
    //    rigidbody.useGravity = false;
    //}

    //TODO
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
