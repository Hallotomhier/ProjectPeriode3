using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontal;
    public float vertical;
    public Vector3 movement;
    public float movementSpeed;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical  = Input.GetAxis("Vertical");
        movement.x = horizontal;
        movement.z = vertical;
        transform.Translate(movement * movementSpeed * Time.deltaTime);
        Sprint();
    }


    public void Sprint() 
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            movementSpeed = 5;
        }
        else 
        {
            movementSpeed = 2.5f;        
        }
    }
}
