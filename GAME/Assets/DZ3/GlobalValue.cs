using UnityEngine;

public class Global : MonoBehaviour
{
    private int globalValue = default;
    
    private int minLoseValue = default;
    private int maxWinValue = default;
    private int drawValue = default;
    private SpawnAndDelateDice spawn;
    private int oldGlobalValue;

    public int OldGlobalValue
    {
        get { return oldGlobalValue; }
        set { oldGlobalValue = value; }
    }

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
        spawn = FindObjectOfType<SpawnAndDelateDice>();
    }   

    public void AddValue(int amount)
    {
        globalValue += amount;
    }
}
