using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSound : MonoBehaviour
{
    public AudioSource footstep;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WalkingSound();
    }


    public void WalkingSound() 
    {
        if (Input.GetKey(KeyCode.W))
        {
            footstep.Play();

            if (Input.GetKey(KeyCode.A)) 
            {
                footstep.Play();
                
                if (Input.GetKey(KeyCode.S)) 
                {
                    footstep.Play();

                    if (Input.GetKey(KeyCode.D))
                    {
                        footstep.Play();
                    }
                    else 
                    {
                        footstep.Stop();
                    }
                
                }
            }
        }
        

    }
}
