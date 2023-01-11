using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp1 : MonoBehaviour
{
    public bool Action;
    public static bool L1IsBlue = false;
    public static bool L1IsGreen = false;
    public static bool L1IsRed = true;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light6;

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
                if(L1IsRed == true){L1IsRed=false;L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L1IsBlue == true){L1IsBlue=false;L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L1IsGreen=false;L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp2.L2IsRed == true){Room4Lamp2.L2IsRed=false;Room4Lamp2.L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp2.L2IsBlue == true){Room4Lamp2.L2IsBlue=false;Room4Lamp2.L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp2.L2IsGreen=false;Room4Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp6.L6IsRed == true){Room4Lamp6.L6IsRed=false;Room4Lamp6.L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp6.L6IsBlue == true){Room4Lamp6.L6IsBlue=false;Room4Lamp6.L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp6.L6IsGreen=false;Room4Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}

            }
        }
    }
}
