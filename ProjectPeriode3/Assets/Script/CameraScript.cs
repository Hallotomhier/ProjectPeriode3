using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public RaycastHit hit;
    public Camera cam1;
    public Camera cam2;
   

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }


    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out hit, 3f))
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                Debug.Log("E");


                if (hit.transform.CompareTag("TV1"))
                {
                    //cam1.enabled = !cam1.enabled;
                    cam2.enabled = !cam2.enabled;

                }

                

            }
            



        }


        if (cam2.enabled == true) 
        {
            if (Input.GetKeyDown(KeyCode.Escape)) 
            {
                cam1.enabled = true;
                cam2.enabled = false;
            }
        
        
        
        }
    }

















}
