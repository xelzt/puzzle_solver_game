using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Lamp1 : MonoBehaviour
{
    public bool Action;
    public static bool R3L1IsRed = true;
    public static bool R3L1IsBlue = false;
    public static bool R3L1IsGreen = false;
    public GameObject Light1;
    public GameObject Light2;

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
                if(R3L1IsRed == true){R3L1IsRed=false;R3L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R3L1IsBlue == true){R3L1IsBlue=false;R3L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R3L1IsGreen=false;R3L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp2.R3L2IsRed == true){Room3Lamp2.R3L2IsRed=false;Room3Lamp2.R3L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp2.R3L2IsBlue == true){Room3Lamp2.R3L2IsBlue=false;Room3Lamp2.R3L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp2.R3L2IsGreen=false;Room3Lamp2.R3L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
