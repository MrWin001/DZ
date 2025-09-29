using UnityEngine;

public class SpawnDice : MonoBehaviour
{
    [SerializeField] private int countSpawnerDice;
    private System.Random variableRandomness;
    [SerializeField] private Dice dicePrefab;
    private TrigersScripts triggerScript;
    private Global globalValue;
    private void Start()
    {
        variableRandomness = new System.Random();
        if (dicePrefab == null)
        {
            Debug.LogError("Dice Prefab не назначен в инспекторе!");
            return;
        }
        SpawnMultipleDice();
    }

    private void SpawnMultipleDice()
    {
        for (var i = 0; i < countSpawnerDice; i++)
        {
            var newDice = Instantiate(dicePrefab,
                new Vector3(
                    variableRandomness.Next(5,10),
                    variableRandomness.Next(5, 10), 
                    variableRandomness.Next(5,10)), 
                Quaternion.identity);

            newDice.variableRandomnes = variableRandomness;
         
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerScript != null)
        {
            triggerScript.SideCollider = other;
        }
    }
}
