using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public RaycastHit hit;
    public float pickUpTotaal;
    public GameObject deur;
    public Transform player;
    public float openDoorSpeed;
    
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        
        if (Physics.Raycast(transform.position , transform.forward, out hit, 1f)) 
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
                    player.transform.Translate(0, -5, 0);
                }
                
                if (hit.transform.CompareTag("Trap")) 
                {
                    player.transform.Translate(0,5,0);
                    
                }

                if (hit.transform.CompareTag("Door")) 
                {
                    deur.transform.Rotate(0, -90, 0);
                  

                }



            }
        }
    }
}
