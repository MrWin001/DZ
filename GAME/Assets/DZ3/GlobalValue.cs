using UnityEngine;

public class Global : MonoBehaviour
{

    private int globalValue = 0;

    public int GlobalValue
    {
        get { return globalValue; }
        set 
        {
            globalValue += value; 
        }
    }
    private void Awake()
    {
        globalValue = 0;
    }
    public void AddValue(int amount)
    {
        globalValue += amount;
    }
}
