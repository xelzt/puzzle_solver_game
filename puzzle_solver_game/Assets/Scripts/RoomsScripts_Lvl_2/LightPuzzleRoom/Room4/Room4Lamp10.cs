using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room4Lamp10 : MonoBehaviour
{
    public bool Action;
    public static bool L10IsRed = true;
    public static bool L10IsBlue = false;
    public static bool L10IsGreen = false;
    public GameObject Light9;
    public GameObject Light10;

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
                if(L10IsRed == true){L10IsRed=false;L10IsBlue=true;
                Light10.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(L10IsBlue == true){L10IsBlue=false;L10IsGreen=true;
                Light10.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{L10IsGreen=false;L10IsRed=true;
                Light10.GetComponent<Animation>().Play("LightChangeGreenRed");}



                if(Room4Lamp9.L9IsRed == true){Room4Lamp9.L9IsRed=false;Room4Lamp9.L9IsBlue=true;
                Light9.GetComponent<Animation>().Play("LightChangeRedBlue");}
                else if(Room4Lamp9.L9IsBlue == true){Room4Lamp9.L9IsBlue=false;Room4Lamp9.L9IsGreen=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");}
                else{Room4Lamp9.L9IsGreen=false;Room4Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}
        }}
    }
}
