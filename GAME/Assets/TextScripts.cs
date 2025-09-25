using UnityEngine;
using UnityEngine.UI;

public class TextScripts : MonoBehaviour
{
    private Text text;
    public static int points;

    private void Awake()
    {
        text = GetComponent<Text>();
    }
    public void UpdateText()
    {
        text.text = points.ToString();
    }
}
