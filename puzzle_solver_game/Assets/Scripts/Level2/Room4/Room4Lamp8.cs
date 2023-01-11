using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp8 : MonoBehaviour
{
    public bool Action;
    public static bool L8IsRed = true;
    public static bool L8IsBlue = false;
    public static bool L8IsGreen = false;
    public GameObject Light9;
    public GameObject Light7;
    public GameObject Light8;

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
               if(L8IsRed == true){L8IsRed=false;L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L8IsBlue == true){L8IsBlue=false;L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L8IsGreen=false;L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp7.L7IsRed == true){Room4Lamp7.L7IsRed=false;Room4Lamp7.L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp7.L7IsBlue == true){Room4Lamp7.L7IsBlue=false;Room4Lamp7.L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp7.L7IsGreen=false;Room4Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}
                
                if(Room4Lamp9.L9IsRed == true){Room4Lamp9.L9IsRed=false;Room4Lamp9.L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp9.L9IsBlue == true){Room4Lamp9.L9IsBlue=false;Room4Lamp9.L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp9.L9IsGreen=false;Room4Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
