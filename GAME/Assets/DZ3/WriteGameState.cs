using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class WriteGameState : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI stateGame;
    private Global globalValue;
    private SpawnAndDelateDice spawnAndDelateDice;
    private TrigersScripts triggerScript;

    private void SomparisonState()
    {
        if (globalValue == null || stateGame == null) return;

        if
            (
            globalValue.GlobalValue > globalValue.MaxWinValue
            && globalValue.GlobalValue != 0
            )
        {
            stateGame.text = "Подеба";
            stateGame.color = Color.green;           
        }

        else if (
            globalValue.GlobalValue < globalValue.MaxWinValue
            && globalValue.GlobalValue > globalValue.MinLoseValue
            && globalValue.GlobalValue != 0
            )
        {

            stateGame.text = "Ничья";
            stateGame.color = Color.plum;
        }

        else
        {
            stateGame.text = "Поражение";
            stateGame.color = Color.red;
        }

    }

    private void Awake()
    {
        globalValue = FindObjectOfType<Global>();
        spawnAndDelateDice = FindObjectOfType<SpawnAndDelateDice>();
    }

    public void ClearState()
    {
        stateGame.text = default;
        stateGame.color = default;
    }

    private void FixedUpdate()
    {
        if (spawnAndDelateDice.wasSpawnDices == true)
        {
            Invoke("SomparisonState", 3);            
        }
    }
}

