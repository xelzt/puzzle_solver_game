using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Lamp5 : MonoBehaviour
{
    public bool Action;
    public static bool R3L5IsRed = true;
    public static bool R3L5IsBlue = false;
    public static bool R3L5IsGreen = false;
    public GameObject Light4;
    public GameObject Light5;

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
        {if (Action==true)
            {
                if(R3L5IsRed == true){R3L5IsRed=false;R3L5IsBlue=true;
                Light5.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R3L5IsBlue == true){R3L5IsBlue=false;R3L5IsGreen=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R3L5IsGreen=false;R3L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp4.R3L4IsRed == true){Room3Lamp4.R3L4IsRed=false;Room3Lamp4.R3L4IsBlue=true;
                Light4.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp4.R3L4IsBlue == true){Room3Lamp4.R3L4IsBlue=false;Room3Lamp4.R3L4IsGreen=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp4.R3L4IsGreen=false;Room3Lamp4.R3L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }
    }
    }
}
