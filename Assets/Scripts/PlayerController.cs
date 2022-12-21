using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float Speed = 20;
    private float TurnSpeed = 45;
    private float HorizontalInput;
    private float VerticalInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");

        //Moves the car in forward direction
        transform.Translate(Vector3.forward * Time.deltaTime * Speed * VerticalInput);
        //Moves the car in either right or left direction
        transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * HorizontalInput);
    }
}
