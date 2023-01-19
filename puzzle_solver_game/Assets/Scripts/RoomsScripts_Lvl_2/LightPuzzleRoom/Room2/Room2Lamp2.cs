using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Lamp2 : MonoBehaviour
{
    public bool Action;
    public static bool R2L2IsRed = true;
    public static bool R2L2IsBlue = false;
    public static bool R2L2IsGreen = false;
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
                if(R2L2IsRed == true){R2L2IsRed=false;R2L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R2L2IsBlue == true){R2L2IsBlue=false;R2L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R2L2IsGreen=false;R2L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room2Lamp1.R2L1IsRed == true){Room2Lamp1.R2L1IsRed=false;Room2Lamp1.R2L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room2Lamp1.R2L1IsBlue == true){Room2Lamp1.R2L1IsBlue=false;Room2Lamp1.R2L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room2Lamp1.R2L1IsGreen=false;Room2Lamp1.R2L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room2Lamp3.R2L3IsRed == true){Room2Lamp3.R2L3IsRed=false;Room2Lamp3.R2L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room2Lamp3.R2L3IsBlue == true){Room2Lamp3.R2L3IsBlue=false;Room2Lamp3.R2L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room2Lamp3.R2L3IsGreen=false;Room2Lamp3.R2L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
       
    }
}
