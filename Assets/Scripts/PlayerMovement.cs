using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float FowardSpeed = 15f;
    public float JumpHeight = 50f;
    public float HorizontalSpeed = 15f;
    public Rigidbody rb;
    public bool PlayerOnGround = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

        if (Input.GetButtonDown("Jump") && PlayerOnGround && (Input.GetKey("w")))
        {

            rb.AddForce(new Vector3(0, JumpHeight, FowardSpeed), ForceMode.Impulse);
            PlayerOnGround = false;

        }

        if (Input.GetButtonDown("Jump") && PlayerOnGround && (Input.GetKey("a")))
        {

            rb.AddForce(new Vector3(-HorizontalSpeed, JumpHeight, FowardSpeed), ForceMode.Impulse);
            PlayerOnGround = false;

        }

        if (Input.GetButtonDown("Jump") && PlayerOnGround && (Input.GetKey("d")))
        {

            rb.AddForce(new Vector3(HorizontalSpeed, JumpHeight, FowardSpeed), ForceMode.Impulse);
            PlayerOnGround = false;

        }

        if (Input.GetButtonDown("Jump") && PlayerOnGround && (Input.GetKey("s")))
        {

            rb.AddForce(new Vector3(0, JumpHeight, -FowardSpeed), ForceMode.Impulse);
            PlayerOnGround = false;

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            PlayerOnGround = true;
        }
    }
}
