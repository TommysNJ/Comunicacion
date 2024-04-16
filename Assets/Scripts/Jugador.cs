using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cuboAColor;
    int cameraSpeed = 700;
    float jumpForce = 4.0f;
    private Rigidbody Physics;  
    [SerializeField]
    int speedPlayer = 3;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float rotationY = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,rotationY * cameraSpeed * Time.deltaTime,0));

        if (Input.GetKeyDown(KeyCode.E))
        {
            cuboAColor.GetComponent<Renderer>().material.color = Random.ColorHSV(); // Cambiar a un color aleatorio
        }

        if(Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speedPlayer * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speedPlayer * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Physics.AddForce(new Vector3(0,jumpForce,0), ForceMode.Impulse);
        }

        

    }
}
