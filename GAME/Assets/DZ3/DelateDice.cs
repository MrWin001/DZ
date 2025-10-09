using UnityEngine;

public class DelateDice : MonoBehaviour
{
    [SerializeField] private Dices DelatedicePrefab;
    public void DelateDices() => ToDelateDice();
    private void ToDelateDice()
    {
        Destroy(DelatedicePrefab, 4);
    }
}
