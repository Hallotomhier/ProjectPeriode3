using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingAndLoading : MonoBehaviour
{

    public SaveLoadData saveLoadData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F5))
        {
            // Saves Data

            saveLoadData.SavePlayer();
        }       

        if (Input.GetKeyDown(KeyCode.F6))
        {
            // Loads Data
            saveLoadData.LoadPlayer();

        }
    }
}
