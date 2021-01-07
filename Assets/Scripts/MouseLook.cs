using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour {

    private float xRotation = 0f;

    public float mouseSensitivity = 300f;

    public Transform playerBody;

    // Start is called before the first frame update
    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update() {
        float difference = mouseSensitivity * Time.deltaTime;
        float mouseX = Input.GetAxis("Mouse X") * difference;
        float mouseY = Input.GetAxis("Mouse Y") * difference;
        
        playerBody.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }
}
