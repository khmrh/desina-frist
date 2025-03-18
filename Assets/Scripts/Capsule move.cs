using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Capsulemove : MonoBehaviour
{
    public float Speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {

    }   
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }
}
