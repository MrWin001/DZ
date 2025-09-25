using UnityEngine;

public class CheckZone : MonoBehaviour
{
    private Vector3 diceVelocity;  
    public static int point;

    void FixedUpdate()
    {
        diceVelocity = ThrowingDice.DiceVelocity;
    }

    private void OnTrigerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    point = 6;
                    
                    break;
                case "Side2":
                    point = 5;
                  
                    break;
                case "Side3":
                    point = 4;
                   
                    break;
                case "Side4":
                    point = 3;
                  
                    break;
                case "Side5":
                    point = 2;
                   
                    break;
                case "Side6":
                    point = 1;
                    
                    break;
                default:
                    break;
            }
        }
    }
}
