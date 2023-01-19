using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3Lamp2 : MonoBehaviour
{
    public bool Action;
    public static bool R3L2IsRed = true;
    public static bool R3L2IsBlue = false;
    public static bool R3L2IsGreen = false;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;

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
                if(R3L2IsRed == true){R3L2IsRed=false;R3L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R3L2IsBlue == true){R3L2IsBlue=false;R3L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R3L2IsGreen=false;R3L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp1.R3L1IsRed == true){Room3Lamp1.R3L1IsRed=false;Room3Lamp1.R3L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp1.R3L1IsBlue == true){Room3Lamp1.R3L1IsBlue=false;Room3Lamp1.R3L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp1.R3L1IsGreen=false;Room3Lamp1.R3L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room3Lamp3.R3L3IsRed == true){Room3Lamp3.R3L3IsRed=false;Room3Lamp3.R3L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room3Lamp3.R3L3IsBlue == true){Room3Lamp3.R3L3IsBlue=false;Room3Lamp3.R3L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room3Lamp3.R3L3IsGreen=false;Room3Lamp3.R3L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
       
    }
}
