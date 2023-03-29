using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mousSens, mouseY, mouseX;
    public Vector3 dir;
    public GameObject playerBody;

    void Start()
    {
        
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mousSens;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mousSens;

        mouseY = Mathf.Clamp(mouseY, -90, 90);

        dir = new Vector3(0, mouseX, 0);
        playerBody.transform.Rotate(dir * mousSens * Time.deltaTime);

        dir = new Vector3(-mouseY, 0, 0);
        transform.Rotate(dir * mousSens * Time.deltaTime);










    }
}
