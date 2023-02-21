using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastRay : MonoBehaviour
{
    public RaycastHit hit;
    public Transform playerCharacter;
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
                if (hit.transform.CompareTag("Trap")) 
                {
                    transform.Translate(Vector3.up);
                    playerCharacter.transform.Translate(Vector3.up);
                }
            }
        }
    }
}
