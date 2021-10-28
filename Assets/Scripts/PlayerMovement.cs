using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public float MoveSpeed;
    public float UpSpeed;
    public float RightSpeed;
    public float LeftSpeed;

    void Update()
    {

        Physics.gravity = new Vector3(0, -120f, 0);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(0, UpSpeed, 0 * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, MoveSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))
        {
            rb.AddForce(RightSpeed / 50, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(LeftSpeed / 50, 0, 0 * Time.deltaTime, ForceMode.VelocityChange);
        }

    }

}
