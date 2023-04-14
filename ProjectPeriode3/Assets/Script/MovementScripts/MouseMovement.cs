using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    public float mousSens, mouseY, mouseX ,rotY;
    public Vector3 dir , clampY;
    public GameObject playerBody;
    

    void Start()
    {
        
    }

    
    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mousSens;
        mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mousSens;

        dir = new Vector3(0, mouseX, 0);
        playerBody.transform.Rotate(dir * mousSens * Time.deltaTime);

        dir = new Vector3(-mouseY, 0, 0);
        transform.Rotate(dir * mousSens * Time.deltaTime);

        rotY += mouseY;
        rotY = Mathf.Clamp(rotY, -90, 90);
        clampY = transform.eulerAngles;
        clampY.x = -rotY;
        transform.eulerAngles = clampY;

        //eulur angels = 
    }
}
