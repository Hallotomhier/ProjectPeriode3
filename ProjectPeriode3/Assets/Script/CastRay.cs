using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public RaycastHit hit;
    public float pickUpTotaal;
    public Transform player;
    public GameObject hatch;
    public GameObject ladder;
    public InventorySystem inventorySystem;
    public GameObject endscreenUi;

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
                    pickUpTotaal += 1;
                }
                if (hit.transform.CompareTag("Engine"))
                {
                    if (pickUpTotaal == 5) // alle items verzameld
                    {
                        endscreenUi.SetActive(true);
                    }
                    else // Mist nog items
                    {
                        print("missing item");
                    }
                }


                //TOM
                if (hit.transform.CompareTag("Ladder")) 
                {
                    player.transform.position = hatch.transform.position;
                }
                
                if (hit.transform.CompareTag("Hatch")) 
                {
                    player.transform.position = ladder.transform.position;
                    
                }

                

                

            }
        }
    }




}
