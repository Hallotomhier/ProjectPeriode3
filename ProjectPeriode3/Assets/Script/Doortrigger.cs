using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public float speed;
    public Vector3 start;
    
    
    void Start()
    {
        start = transform.position;
    }

    
    void Update()
    {
        
        
    }


    

    void OnTriggerStay(Collider other)
    {
        
        transform.Translate(Vector3.up * speed * Time.deltaTime);
        
    }

    void OnTriggerExit(Collider other) 
    {
        


        transform.position = start;
    }
    




}
