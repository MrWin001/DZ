using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Subsystems;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;
using static UnityEngine.GraphicsBuffer;
using static UnityEngine.Rendering.DebugUI.Table;

public class MovingBox : MonoBehaviour
{
    [SerializeField]public GameObject Box;
    [SerializeField] private int boxCounter;
    [SerializeField] private float speed = 20f;
    [SerializeField] private float angle = 15f;
    [SerializeField] private Vector3 center = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 axis = new Vector3(0, 10, 0);
    [SerializeField] private bool otherDirection;
    private float radius = 5f;

    private GameObject[] boxes;

    void Start()
    {

        if (Box == null)
        {
            Debug.LogError("Box was is null");
            return;
        }

        boxes = new GameObject[boxCounter];

        for (int i = 0; i < boxes.Count(); i++)
        {
            var angle = i * Mathf.PI * 2 / boxCounter;
            var position = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            boxes[i] = Instantiate(Box, position, Quaternion.identity);
        }    
    }


    private void Awake()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Box == null)
        {
            Debug.LogError("Box was is null");
            return;
        }

        foreach (var box in boxes)
        {
            if (otherDirection == true)
            {
                box.transform.RotateAround(center, -axis, speed * speed * Time.deltaTime);
                box.transform.Rotate(angle, 0, 0);
            }
            else
            {
                box.transform.RotateAround(center, axis, speed * speed * Time.deltaTime);
                box.transform.Rotate(angle,0,0);
            }
        }
    }
}