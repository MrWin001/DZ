using UnityEngine;

public class TrigersScripts : MonoBehaviour
{
    private Collider sideCollider;
    private int currentValue;
    private Global globalValue;
    private Rigidbody RB;

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
        RB = GetComponent<Rigidbody>();
        if (RB == null) Debug.Log($"Rigidbody не найден на объекте");
        globalValue = FindFirstObjectByType<Global>();
    }

    private void OnTriggerEnter(Collider sideCollider)
    {
        var tag = sideCollider.tag;
        switch (tag)
        {
            case "1":
                currentValue = 6;
                globalValue.AddValue(currentValue);               
                break;
            case "2":
                currentValue = 5;
                globalValue.AddValue(currentValue);                
                break;
            case "3":
                currentValue = 4;
                globalValue.AddValue(currentValue);               
                break;
            case "4":
                currentValue = 3;
                globalValue.AddValue(currentValue);                
                break;
            case "5":
                currentValue = 2;
                globalValue.AddValue(currentValue);         
                break;
            case "6":
                currentValue = 1;
                globalValue.AddValue(currentValue);                
                break;
            default:
                //Debug.LogWarning($"Неизвестный тег триггера: {tag}");
                break;
        }
    }

    private void OnTriggerExit(Collider sideCollider)
    {
        var tag = sideCollider.tag;
        switch (tag)
        {
            case "1":
                currentValue = -6;
                globalValue.AddValue(currentValue);
                break;
            case "2":
                currentValue = -5;
                globalValue.AddValue(currentValue);
                break;
            case "3":
                currentValue = -4;
                globalValue.AddValue(currentValue);
                break;
            case "4":
                currentValue = -3;
                globalValue.AddValue(currentValue);
                break;
            case "5":
                currentValue = -2;
                globalValue.AddValue(currentValue);
                break;
            case "6":
                currentValue = -1;
                globalValue.AddValue(currentValue);
                break;
            default:
                break;
        }
    }
}
