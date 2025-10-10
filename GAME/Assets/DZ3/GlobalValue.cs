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
            if (value > 0) drawValue = value;        
        }
    }

    public int MaxWinValue
    {
        get { return maxWinValue; }
        set 
        {
            if (value > 0) maxWinValue = value; 
        }
    }

    public int MinLoseValue
    {
        get { return minLoseValue; }
        set 
        { 
            if (value > 0) minLoseValue = value; 
        }
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
