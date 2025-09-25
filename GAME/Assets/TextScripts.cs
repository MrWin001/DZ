using System.Drawing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextScripts : MonoBehaviour
{
    private TextMeshProUGUI text;
    private int points = CheckZone.point;

    public void UpdateText()
    {
        text.text = points.ToString();        
    }
}
