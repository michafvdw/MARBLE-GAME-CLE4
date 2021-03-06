using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody rb;
    public float moveSpeed = 10f;

    private float xInput;
    private float zInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //good for handling inputs and animations
        ProcessInputs();
    }

    private void FixedUpdate()
    {
        //movement 
        Move();
    }

    private void ProcessInputs()
    {
        //use Z axis instead of Y because its a 3D game
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

    }

    private void Move()
    {
        //adding speed to the movement
        rb.AddForce(new Vector3(xInput, 0f, zInput) * moveSpeed);
    }
}
