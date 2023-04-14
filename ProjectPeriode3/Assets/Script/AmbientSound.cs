using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientSound : MonoBehaviour
{
    public AudioSource ambient;
    void Start()
    {
        
    }

    
    void Update()
    {
        ambient.Play();
    }
};
