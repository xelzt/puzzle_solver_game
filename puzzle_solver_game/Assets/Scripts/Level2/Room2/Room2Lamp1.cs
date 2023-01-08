using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room2Lamp1 : MonoBehaviour
{
    public bool Action;
    public static bool R2L1IsRed = true;
    public static bool R2L1IsBlue = false;
    public static bool R2L1IsGreen = false;
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
                if(R2L1IsRed == true){R2L1IsRed=false;R2L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(R2L1IsBlue == true){R2L1IsBlue=false;R2L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{R2L1IsGreen=false;R2L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room2Lamp2.R2L2IsRed == true){Room2Lamp2.R2L2IsRed=false;Room2Lamp2.R2L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room2Lamp2.R2L2IsBlue == true){Room2Lamp2.R2L2IsBlue=false;Room2Lamp2.R2L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room2Lamp2.R2L2IsGreen=false;Room2Lamp2.R2L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
