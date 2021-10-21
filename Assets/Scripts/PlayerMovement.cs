using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float MoveSpeed;
    public float UpSpeed;
    public float shiftSpeed;

    bool grounded = true;

    // Update is called once per frame

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { grounded = true; }
    }

    public void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground")) { grounded = false; }
    }

    void Update()
    {

        Physics.gravity = new Vector3(0, -120f, 0);



        if (Input.GetKeyDown("space") && grounded)
        {
            rb.AddForce(0, UpSpeed, 0 * Time.deltaTime);

        }

        if (Input.GetKey("w"))

        {
            rb.AddForce(0, 0, MoveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -MoveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-MoveSpeed / 50, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(MoveSpeed / 50, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }


        if (Input.GetKeyDown("left shift"))
        {
            MoveSpeed = shiftSpeed;
        }

        if (Input.GetKeyDown("left shift"))
        {
            shiftSpeed = MoveSpeed;
        }

        if (Input.GetKeyUp("left shift"))
        {
            MoveSpeed = 100f;
        }



    }

}
