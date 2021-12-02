using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject squarePointer;

    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = squarePointer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        squarePointer.transform.position = initialPosition + Input.mousePosition / 100;
    }
}
