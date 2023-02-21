using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public RaycastHit hit;
    public Transform playerCharacter;
    public float pickUpTotaal;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        if (Physics.Raycast(transform.position , transform.forward, out hit, 5f)) 
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                if (hit.transform.CompareTag("PickUp")) 
                {
                    Destroy(hit.transform.gameObject);
                    pickUpTotaal += 1;
                }

                if (hit.transform.CompareTag("TrapDown")) 
                {
                    transform.Translate(0, -5, 0);
                }
                
                
                
                
                
                if (hit.transform.CompareTag("Trap")) 
                {
                    transform.Translate(0,5,0);
                    
                }
            }
        }
    }
}
