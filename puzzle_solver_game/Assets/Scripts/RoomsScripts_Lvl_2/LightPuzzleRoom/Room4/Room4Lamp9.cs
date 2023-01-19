using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp9 : MonoBehaviour
{
    public bool Action;
    public static bool L9IsRed = true;
    public static bool L9IsBlue = false;
    public static bool L9IsGreen = false;
    public GameObject Light9;
    public GameObject Light10;
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
               if(L9IsRed == true){L9IsRed=false;L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L9IsBlue == true){L9IsBlue=false;L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L9IsGreen=false;L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}


                if(Room4Lamp8.L8IsRed == true){Room4Lamp8.L8IsRed=false;Room4Lamp8.L8IsBlue=true;
                Light8.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp8.L8IsBlue == true){Room4Lamp8.L8IsBlue=false;Room4Lamp8.L8IsGreen=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp8.L8IsGreen=false;Room4Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room4Lamp10.L10IsRed == true){Room4Lamp10.L10IsRed=false;Room4Lamp10.L10IsBlue=true;
                Light10.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp10.L10IsBlue == true){Room4Lamp10.L10IsBlue=false;Room4Lamp10.L10IsGreen=true;
                Light10.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp10.L10IsGreen=false;Room4Lamp10.L10IsRed=true;
                Light10.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
