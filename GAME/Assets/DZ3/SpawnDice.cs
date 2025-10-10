using UnityEngine;

public class SpawnDice : MonoBehaviour
{
    [SerializeField] private Dices dicePrefab;
    private System.Random variableRandomness;
    private TrigersScripts triggerScript;
    private Rigidbody RB;
    private int countSpawnerDice = 1;

    public int CountSpawnerDice
    {
        get { return countSpawnerDice; }
        set { countSpawnerDice = value; }
    }

    private void Awake()
    {
        RB = GetComponent<Rigidbody>();
        variableRandomness = new System.Random();
    }
    
    private void SpawnMultipleDice()
    {
        for (var i = 1; i < countSpawnerDice; i++)
        {

            var newDice = Instantiate(dicePrefab,
                new Vector3(
                    variableRandomness.Next(10, 20),
                    variableRandomness.Next(10, 20),
                    variableRandomness.Next(5, 10)),
                Quaternion.identity);

            newDice.variableRandomnes = variableRandomness;
            i++;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (triggerScript != null)
        {
            triggerScript.SideCollider = other;
        }
    }

    public void SpawnDices() => SpawnMultipleDice();
}
