using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    void Start()
    {
        // we are going into the transform for the Driver, which is the car, and we are accessing its rotattion property
        // it takes its 3 values - x, y, z

    }

    void Update()
    {
        transform.Rotate(0, 0, 0.1f);
        transform.Translate(0, 0.01f, 0);
    }
}
