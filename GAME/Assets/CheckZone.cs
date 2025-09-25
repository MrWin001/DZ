using UnityEngine;

public class CheckZone : MonoBehaviour
{
    Vector3 diceVelocity;  
    private int point;

    void FixedUpdate()
    {
        diceVelocity = ThrowingDice.DiceVelocity;
    }

    public void OnTrigerStay(Collider col)
    {
        if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
        {
            switch (col.gameObject.name)
            {
                case "Side1":
                    point = 6;
                    TextScripts.points = point;
                    break;
                case "Side2":
                    point = 5;
                    TextScripts.points = point;
                    break;
                case "Side3":
                    point = 4;
                    TextScripts.points = point;
                    break;
                case "Side4":
                    point = 3;
                    TextScripts.points = point;
                    break;
                case "Side5":
                    point = 2;
                   TextScripts.points = point;
                    break;
                case "Side6":
                    point = 1;
                    TextScripts.points = point;
                    break;
                default:
                    break;
            }
        }
    }
}
