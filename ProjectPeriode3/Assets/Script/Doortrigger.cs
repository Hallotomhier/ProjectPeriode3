using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doortrigger : MonoBehaviour
{
    public float speed;
    public Transform player;
    public float delay;
    public float timer;
    public bool doorIsClosed;
    public Vector3 startPos;


    void Start()
    {
        doorIsClosed = true;
        startPos = transform.position;
    }


    void Update()
    {
        if (doorIsClosed == false) 
        {
            timer += 1 * Time.deltaTime;
            if(timer >= 3f) 
            {
                Debug.Log("delay reset");
                timer -= timer;
                CloseDoor();
                doorIsClosed = true;

            }
        }
    }




    void OnTriggerExit(Collider player)
    {
        doorIsClosed = false;
    }

    void OnTriggerStay(Collider player)
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }


    public void CloseDoor() 
    {
        transform.position = startPos;
    }

    

}
