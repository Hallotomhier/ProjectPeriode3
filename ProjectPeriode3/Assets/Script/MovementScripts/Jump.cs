using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public RaycastHit hit;
    public bool grounded;
    public float force = 1000f;
    public Rigidbody rb;
    void Update()
    {
        rb = GetComponent<Rigidbody>();

        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))
        {
            grounded = true;
            //Debug.Log("grounded");

        }
        else 
        {
            grounded = false;
        }
        if (grounded == true) 
        {
            if (Input.GetKeyDown(KeyCode.Space)) 
            {
                rb.AddForce(Vector3.up * force, ForceMode.Impulse);
            }
            




        }
    }

  
 
}
