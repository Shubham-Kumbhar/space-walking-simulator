using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float MouseSensitivityx;
    public float MouseSensitivityy;
    public Transform playerBody;
    public float xRotation = 0f;
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.lockState = CursorLockMode.Locked;
        t = xRotation + 90;
        xRotation = 0f;
        transform.localRotation = Quaternion.Euler(t, 0f, 0f);
    }

    // Update is called once per frame
    void LateUpdate()
    {

        float mouseX = Input.GetAxis("Mouse X") * MouseSensitivityx * Time.deltaTime;

        float mouseY = Input.GetAxis("Mouse Y") * MouseSensitivityy * Time.deltaTime;

        xRotation -= mouseY;

        xRotation = Mathf.Clamp(xRotation, -50f, 70f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }




}