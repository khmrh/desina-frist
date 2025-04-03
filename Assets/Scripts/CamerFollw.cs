using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollw : MonoBehaviour
{

    public float rotationSpeed = 15f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    // Update is called once per frame
    void Update()
    {
        float moveX = Input.mousePosition.x * rotationSpeed * Time.deltaTime;
        float moveY = -Input.mousePosition.y * rotationSpeed * Time.deltaTime;

        float yRotate = moveY * rotationSpeed;
        float xRotate = moveX * rotationSpeed;

        //yRotate = Matht.Clamp(yRotate, -80, 80);

        transform.rotation = Quaternion.Euler(yRotate,xRotate, 0);

    }
}
