using UnityEngine;

public class DelateDice : MonoBehaviour
{
    [SerializeField] private Dices DelateDicePrefab;

    private void ToDelateDice()
    {
        Destroy(DelateDicePrefab, 4);
    }

    public void DelateDices() => ToDelateDice();
}
