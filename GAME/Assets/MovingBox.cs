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
    [SerializeField] private GameObject Box;
    [SerializeField] private int boxCounter;
    [SerializeField] private float speed = 20f;
    [SerializeField] private float angleRotationAxis = 15f;
    [SerializeField] private float radius = 5f;
    [SerializeField] private Vector3 center = new Vector3(0, 0, 0);
    [SerializeField] private Vector3 axis = new Vector3(0, 10, 0);
    [SerializeField] private bool IsOtherDirection;

    private GameObject[] boxes;

    private void Awake()
    {
        if (Box == null)
        {
            Debug.LogError("Box was is null");
            return;
        }

        boxes = new GameObject[boxCounter];

        for (int i = 0; i < boxes.Count(); i++)
        {
            boxes[i] = Instantiate(
                Box, 
                new Vector3(Mathf.Cos(i * Mathf.PI *2 / boxCounter), 
                0, 
                Mathf.Sin(i * Mathf.PI * 2 / boxCounter)) * radius, 
                Quaternion.identity);
        }
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
            switch (IsOtherDirection)
            {
                case true:
                    box.transform.RotateAround(center, -axis, speed * speed * Time.deltaTime);
                    box.transform.Rotate(angleRotationAxis, 0, 0);
                break;

                default:
                    box.transform.RotateAround(center, axis, speed * speed * Time.deltaTime);
                    box.transform.Rotate(angleRotationAxis, 0, 0);
                break;
            }
        }
    }
}