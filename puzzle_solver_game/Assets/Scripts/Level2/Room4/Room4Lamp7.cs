using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp7 : MonoBehaviour
{
    public bool Action;
    public static bool L7IsRed = true;
    public static bool L7IsBlue = false;
    public static bool L7IsGreen = false;
    public GameObject Light6;
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
               if(L7IsRed == true){L7IsRed=false;L7IsBlue=true;
                Light7.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L7IsBlue == true){L7IsBlue=false;L7IsGreen=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L7IsGreen=false;L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp6.L6IsRed == true){Room4Lamp6.L6IsRed=false;Room4Lamp6.L6IsBlue=true;
                Light6.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp6.L6IsBlue == true){Room4Lamp6.L6IsBlue=false;Room4Lamp6.L6IsGreen=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp6.L6IsGreen=false;Room4Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}


                if(Room4Lamp8.L8IsRed == true){Room4Lamp8.L8IsRed=false;Room4Lamp8.L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp8.L8IsBlue == true){Room4Lamp8.L8IsBlue=false;Room4Lamp8.L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp8.L8IsGreen=false;Room4Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
