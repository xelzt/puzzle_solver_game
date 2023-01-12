using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBall : MonoBehaviour
{
    public Vector3 rotationAmount = new Vector3(0f, 0f, 90f);
    public int rotationCount = 0;
    public GameObject Ball;
    public bool Action;
    public GameObject Nexus;

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Action = false;
    }

     void Update()
    {
    
       if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true)
            {
            if(Nexus.GetComponent<MeshRenderer>().enabled == true){
            Ball.transform.Rotate(rotationAmount);
            if(rotationCount<3){
            rotationCount++;}else{
            rotationCount=0;
            }}
        }
        }

    }
}

