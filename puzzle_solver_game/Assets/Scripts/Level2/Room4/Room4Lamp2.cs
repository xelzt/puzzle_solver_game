using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp2 : MonoBehaviour
{
    public bool Action;
    public static bool L2IsBlue = false;
    public static bool L2IsGreen = false;
    public static bool L2IsRed = true;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light7;

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
                if(L2IsRed == true){L2IsRed=false;L2IsBlue=true;
                Light2.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L2IsBlue == true){L2IsBlue=false;L2IsGreen=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L2IsGreen=false;L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp1.L1IsRed == true){Room4Lamp1.L1IsRed=false;Room4Lamp1.L1IsBlue=true;
                Light1.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp1.L1IsBlue == true){Room4Lamp1.L1IsBlue=false;Room4Lamp1.L1IsGreen=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp1.L1IsGreen=false;Room4Lamp1.L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp3.L3IsRed == true){Room4Lamp3.L3IsRed=false;Room4Lamp3.L3IsBlue=true;
                Light3.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp3.L3IsBlue == true){Room4Lamp3.L3IsBlue=false;Room4Lamp3.L3IsGreen=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp3.L3IsGreen=false;Room4Lamp3.L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp7.L7IsRed == true){Room4Lamp7.L7IsRed=false;Room4Lamp7.L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp7.L7IsBlue == true){Room4Lamp7.L7IsBlue=false;Room4Lamp7.L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp7.L7IsGreen=false;Room4Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}
            }
        }
    }
}
