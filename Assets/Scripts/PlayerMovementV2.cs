using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementV2 : MonoBehaviour
{
    public float speed = 1.0f;
    public CharacterController controller;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the input of the x axis and sets it as a variable called horizontal...?
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, y);
        // .deltaTime is based on the time not the framerate
        movement = movement.normalized * speed * Time.deltaTime;

        controller.Move(movement);

    }
}
