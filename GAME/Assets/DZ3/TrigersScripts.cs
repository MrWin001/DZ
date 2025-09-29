using UnityEngine;

public class TrigersScripts : MonoBehaviour
{
    private Collider sideCollider;
    private int value;
    private Dice dice;
    private Global globalValue;
    public Collider SideCollider
    {
        get { return sideCollider; }
        set
        {
            if (value == null)
            {
                Debug.Log($"Колайдер равен null");
            }
            else
            {
                sideCollider = value;
            }
        }
    }
    private void Awake()
    {
        globalValue = FindObjectOfType<Global>();
    }


    private void OnTriggerEnter(Collider sideCollider)
    {
        var tag = sideCollider.tag;
        switch (tag)
        {
            case "1":
                value = 6;
                globalValue.AddValue(value);
                // Debug.Log($"{value}");
                break;
            case "2":
                value = 5;
                globalValue.AddValue(value);
                // Debug.Log($"{value}");
                break;
            case "3":
                value = 4;
                globalValue.AddValue(value);
                //Debug.Log($"{value}");
                break;
            case "4":
                value = 3;
                globalValue.AddValue(value);
                // Debug.Log($"{value}");
                break;
            case "5":
                value = 2;
                globalValue.AddValue(value);
                //Debug.Log($"{value}");
                break;
            case "6":
                value = 1;
                globalValue.AddValue(value);
                // Debug.Log($"{value}");
                break;
            default:
                Debug.LogWarning($"Sphere collider не коснулся земли");
                break;
        }
    }
}
