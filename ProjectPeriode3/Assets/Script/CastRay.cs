using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public RaycastHit hit;
    public float pickUpTotaal;
    public GameObject deur;
    public Transform player;
    public Transform level0;
    public Transform level1;
    public float openDoorSpeed;
    public InventorySystem inventorySystem;
    
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
                //JASPER
                if (hit.transform.GetComponent("PickupItem")) 
                {
                    inventorySystem.AddItem(hit.transform.GetComponent<PickupItem>());
                    //hit.transform.GetComponent<PickupItem>();
 
                    //Destroy(hit.transform.gameObject);
                    pickUpTotaal += 1;
                }


                //TOM
                if (hit.transform.CompareTag("TrapDown")) 
                {
                    player.transform.Translate(0, -5, 0);
                }
                
                if (hit.transform.CompareTag("TrapUp")) 
                {
                    player.transform.Translate(level0.GetComponent<>());
                    
                }

                

                

            }
        }
    }




}
