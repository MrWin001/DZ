using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Ui : MonoBehaviour
{
    [SerializeField] private Dices[] dices;

    [SerializeField] private Button ThrowDiceButton;
    [SerializeField] private Button SpawnDiceButton;
   
    [SerializeField] private TMP_InputField InputMinLoseValue;
    [SerializeField] private TMP_InputField InputMaxWinValue;
    [SerializeField] private TMP_InputField InputDrawValue;
    [SerializeField] private TMP_InputField InputCounterSpawnDice;

    [SerializeField] private TextMeshProUGUI TextGlobalValue;
    [SerializeField] private TextMeshProUGUI MinLoseValue;
    [SerializeField] private TextMeshProUGUI MaxWinValue;
    [SerializeField] private TextMeshProUGUI DrawValue;

    private Global globalValue;
    private SpawnDice spawnDice;
    private DelateDice delateDice;

    private void Awake()
    {
        spawnDice = FindAnyObjectByType<SpawnDice>();
        globalValue = FindFirstObjectByType<Global>();
       
        ThrowDiceButton.onClick.AddListener(ThrowsDice);

        SpawnDiceButton.onClick.AddListener(SpawnDice);
        
        InputMinLoseValue.onValueChanged.AddListener(AppropriateMinLoseValue);
        InputMaxWinValue.onValueChanged.AddListener(AppropriateMaxWinValue);
        InputDrawValue.onValueChanged.AddListener(AppropriateDrawValue);
        InputCounterSpawnDice.onValueChanged.AddListener(AppropriateCounterSpawnDice);
    }

    private void FixedUpdate()
    {
        dices = FindObjectsOfType<Dices>(true);
        delateDice = FindAnyObjectByType<DelateDice>();
        PrintGlobalValue();
        PrintDrawValue();
        PrintWinValue();
        PrintLoseValue();
    }

    private void PrintGlobalValue()
    {
        TextGlobalValue.text = globalValue.GlobalValue.ToString();
    }

    private void AppropriateMinLoseValue(string value)
    {
        globalValue.MinLoseValue = int.Parse(value);
    }

    private void AppropriateMaxWinValue(string value)
    {
        globalValue.MaxWinValue = int.Parse(value);
    }

    private void AppropriateDrawValue(string value)
    {
        globalValue.DrawValue = int.Parse(value);
    }

    private void AppropriateCounterSpawnDice(string value)
    {       
        spawnDice.CountSpawnerDice = int.Parse(value);   
    }

    private void PrintDrawValue()
    {
        DrawValue.text = globalValue.DrawValue.ToString();
    }

    private void PrintWinValue()
    {        
        MaxWinValue.text = globalValue.MaxWinValue.ToString();
    }

    private void PrintLoseValue()
    {
        MinLoseValue.text = globalValue.MinLoseValue.ToString();
    }

    private void ThrowsDice()
    {
        foreach (var item in dices)
        {
            item.ThrowDices();
        }
    }

    private void DelateDiceUi()
    {
        if (delateDice != null)
        {
            delateDice.DelateDices();
        }
        else
        {
            Debug.LogError("Cant delate dices");
        }
    }

    private void SpawnDice()
    {
        if (spawnDice != null)
        {
            spawnDice.SpawnDices();
        }
        else
        {
            Debug.LogError("SpawnDice is null");
        }
    }
}
