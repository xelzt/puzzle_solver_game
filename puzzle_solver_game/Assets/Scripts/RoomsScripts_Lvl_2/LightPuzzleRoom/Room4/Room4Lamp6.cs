using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp6 : MonoBehaviour
{
    public bool Action;
    public static bool L6IsRed = true;
    public static bool L6IsBlue = false;
    public static bool L6IsGreen = false;
    public GameObject Light6;
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
               if(L6IsRed == true){L6IsRed=false;L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L6IsBlue == true){L6IsBlue=false;L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L6IsGreen=false;L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp7.L7IsRed == true){Room4Lamp7.L7IsRed=false;Room4Lamp7.L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp7.L7IsBlue == true){Room4Lamp7.L7IsBlue=false;Room4Lamp7.L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp7.L7IsGreen=false;Room4Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
