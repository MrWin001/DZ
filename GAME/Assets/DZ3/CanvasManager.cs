using TMPro;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    public GameObject dice1;
    public GameObject dice2;

    public GameObject total;
    public static GameObject diceStatic1;
    public static GameObject diceStatic2;
    public static GameObject totalStatic;

    private void Start()
    {
        diceStatic1 = dice1;
        diceStatic2 = dice2;
        totalStatic = total;
    }
    //public static void ShowTotal(int value)
    //{
    //    totalStatic.GetComponent<TextMeshProUGUI>().text = $"Total: {value.ToString()}";
    //}
    //public static void ShowResultDice1(int value)
    //{
    //    diceStatic1.GetComponent<TextMeshProUGUI>().text = $"Dice1: {value.ToString()}";
    //}
    //public static void ShowResultDice2(int value)
    //{
    //    diceStatic2.GetComponent<TextMeshProUGUI>().text = $"Dice2: {value.ToString()}";
    //}
    //public static void ResetDiceResult()
    //{
    //    diceStatic1.GetComponent<TextMeshProUGUI>().text = "Dice1: ";
    //    diceStatic2.GetComponent<TextMeshProUGUI>().text = "Dice2: ";
    //}
}
