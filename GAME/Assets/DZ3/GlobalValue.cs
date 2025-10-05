using UnityEngine;

public class Global : MonoBehaviour
{
    private int globalValue = 0;
    private float time;

    public int GlobalValue
    {
        get { return globalValue; }
        set 
        {
            globalValue = value; 
        }
    }

    private void Awake()
    {
        globalValue = default;
    }

    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if (time > 5)
        {
            Debug.Log($"Global currentValue {globalValue}");
        }
    }

    public void AddValue(int amount)
    {
        globalValue += amount;
    }
}
