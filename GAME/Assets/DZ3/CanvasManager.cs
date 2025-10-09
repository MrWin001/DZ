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
    //public static void ShowTotal(int currentValue)
    //{
    //    totalStatic.GetComponent<TextMeshProUGUI>().Text = $"Total: {currentValue.ToString()}";
    //}
    //public static void ShowResultDice1(int currentValue)
    //{
    //    diceStatic1.GetComponent<TextMeshProUGUI>().Text = $"Dice1: {currentValue.ToString()}";
    //}
    //public static void ShowResultDice2(int currentValue)
    //{
    //    diceStatic2.GetComponent<TextMeshProUGUI>().Text = $"Dice2: {currentValue.ToString()}";
    //}
    //public static void ResetDiceResult()
    //{
    //    diceStatic1.GetComponent<TextMeshProUGUI>().Text = "Dice1: ";
    //    diceStatic2.GetComponent<TextMeshProUGUI>().Text = "Dice2: ";
    //}
}
