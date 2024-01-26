    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float speedV = 2.0f;

    public float speedH = 2.0f;

    private float rotationX = 0.0f;
    private float rotationY = 0.0f;

    void Update()
    {
        rotationY += speedV = Input.GetAxis("Mouse X");
        rotationX -= speedH = Input.GetAxis("Mouse Y");

        rotationX = Mathf.Clamp(rotationX, -30f, 30f);

        transform.eulerAngles = new Vector3(rotationX, rotationY, 0);
    }
}
