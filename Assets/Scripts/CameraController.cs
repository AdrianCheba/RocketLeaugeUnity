using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private const float Y_ANGLE_MIN = 5f;
    private const float Y_ANGLE_MAX = 50f;

    public Transform lookAt;
    public Transform camTransform;

    private Camera cam;

    private float distance = 14f;
    private float currentX = 0f;
    private float currentY = 0f;
    private float sens = 4f;

    private void Start()
    {
        camTransform = transform;
        cam = Camera.main;
    }

    private void LateUpdate()
    {
        currentX += Input.GetAxis("Mouse X") * sens;
        currentY -= Input.GetAxis("Mouse Y") * sens;

        currentY = Mathf.Clamp(currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

        Vector3 dir = new Vector3(0, 0, -distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
    }
}
