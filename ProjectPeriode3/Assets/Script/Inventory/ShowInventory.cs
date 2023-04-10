using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowInventory : MonoBehaviour
{
    public GameObject inventoryUi;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryUi.activeSelf)
            {
                inventoryUi.SetActive(false);
            }
            else
            {
                inventoryUi.SetActive(true);
            }
        }
    }
}
