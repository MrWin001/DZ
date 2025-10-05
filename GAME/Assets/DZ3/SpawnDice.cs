using UnityEngine;

public class SpawnDice : MonoBehaviour
{
    [SerializeField] private int countSpawnerDice;
    private System.Random variableRandomness;
    [SerializeField] private Dice dicePrefab;
    private TrigersScripts triggerScript;
    private Rigidbody RB;
    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
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
            ++i;
            var newDice = Instantiate(dicePrefab,
                new Vector3(
                    variableRandomness.Next(10, 20),
                    variableRandomness.Next(10, 20),
                    variableRandomness.Next(5, 10)),
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
