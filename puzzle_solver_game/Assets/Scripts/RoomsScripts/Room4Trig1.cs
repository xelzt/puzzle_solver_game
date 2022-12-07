using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Trig1 : MonoBehaviour
{
    public GameObject Button;
    public static bool Trig1 = false;
    public GameObject DropIt;
    public bool NeedBool = true;

    void OnTriggerEnter () {
        Button.transform.position += new Vector3(0f, -0.240f, 0f);
        Trig1 = true;
    }
    
    void OnTriggerExit () {
        Button.transform.position += new Vector3(0f, 0.240f, 0f);
        Trig1 = false;
    }

void Update()
    {

        {if (Trig1==true && Room4Trig2.Trig2==true && Trig1 ){
                DropIt.GetComponent<Animation>().Play("DropBoxRoom4"); 
                NeedBool = false;    
            }}
        }
}