using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class SpawnAndDelateDice : MonoBehaviour
{
    [SerializeField] private GameObject dicePrefab;
    private System.Random variableRandomness;
    private TrigersScripts triggerScript;
    private Rigidbody RB;
    private int countSpawnerDice = default;
    private List<Dices> spawnedDices = new List<Dices>();
    private Global globalValue;
    private WriteGameState state;

    public bool wasSpawnDices { get; set; } = false;
    public bool isDelateDices { get; private set; } = default;
    public int CounterWinners { get; set; } = default;
    public int CountSpawnerDice
    {
        get { return countSpawnerDice; }
        set { countSpawnerDice = value; }
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
        variableRandomness = new System.Random();
        globalValue = FindObjectOfType<Global>();
        state = FindObjectOfType<WriteGameState>();
    }

    private void SpawnMultipleDice()
    {
        wasSpawnDices = true;
        for (var i = 0; i < countSpawnerDice; i++)
        {
            var newDice = Instantiate(dicePrefab,
                new Vector3(
                    variableRandomness.Next(10, 20),
                    variableRandomness.Next(4, 10),
                    variableRandomness.Next(5, 10)),
                Quaternion.identity);
            var newDiceComponent = newDice.GetComponent<Dices>();
            spawnedDices.Add(newDiceComponent);
        }
    }

    private void ToDeleteDice()
    {
        foreach (var dice in spawnedDices)
        {
            if (dice != null) Destroy(dice.gameObject);
        }

        isDelateDices = true;
        globalValue.GlobalValue = default;
    }

    private void RespawnDice()
    {
        state.ClearState();
        ToDeleteDice();
        SpawnMultipleDice();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerScript != null)
        {
            triggerScript.SideCollider = other;
        }        
    }

    public void RespawnDices() => RespawnDice();
    public void SpawnDices() => SpawnMultipleDice();   
}
