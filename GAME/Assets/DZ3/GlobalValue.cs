using UnityEngine;

public class Global : MonoBehaviour
{
    private int globalValue;
    private int minLoseValue;
    private int maxWinValue;
    private int drawValue;

    public int DrawValue
    {
        get { return drawValue; }
        set 
        { 

            drawValue = value; 
        }
    }

    public int MaxWinValue
    {
        get { return maxWinValue; }
        set { maxWinValue = value; }
    }

    public int MinLoseValue
    {
        get { return minLoseValue; }
        set { minLoseValue = value; }
    }

    public int GlobalValue
    {
        get { return globalValue; }
        set { globalValue = value; }
    }
    private void Awake()
    {
        globalValue = default;
    }

    public void AddValue(int amount)
    {
        globalValue += amount;
    }
}
