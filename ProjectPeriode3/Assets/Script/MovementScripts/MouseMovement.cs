using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mouseX;
    public float rotateSpeed;
    public float mouseY;
    public Transform player;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        
        transform.Rotate(-mouseY,0,0);
        player.Rotate(Vector3.up * mouseX);
        
    }
}
