
using UnityEngine;

public class Dices : MonoBehaviour
{
    private bool isAbandoned = false;

    private Vector3 startPosition;
    private Rigidbody rB;
    
    public System.Random variableRandomnes { get; set; }
    public bool isTrow { get; set; } = default;
    public bool isGrounded { get; set; } = false;

    [SerializeField]
    public Rigidbody RB
    {
        get { return rB; }
        set
        {
            if (value == null) Debug.LogWarning($"Rb == null");
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
        startPosition = transform.position;
        rB.useGravity = false;
        if (variableRandomnes == null) variableRandomnes = new System.Random();
    }

    private void ThrowDice()
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
        isTrow = true;
    }

    public void ThrowDices() => ThrowDice();
}
