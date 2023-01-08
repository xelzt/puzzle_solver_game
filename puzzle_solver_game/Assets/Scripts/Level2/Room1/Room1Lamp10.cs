using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room1Lamp10 : MonoBehaviour
{
    public bool Action;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    public GameObject Light8;
    public GameObject Light9;

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
                if(Room1Lamp1.L1IsBlue == true){Room1Lamp1.L1IsBlue=false;Room1Lamp1.L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp1.L1IsGreen=false;Room1Lamp1.L1IsRed=true;
                Light1.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp2.L2IsBlue == true){Room1Lamp2.L2IsBlue=false;Room1Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp2.L2IsGreen=false;Room1Lamp2.L2IsRed=true;
                Light2.GetComponent<Animation>().Play("LightChangeGreenRed");}

                if(Room1Lamp3.L3IsBlue == true){Room1Lamp3.L3IsBlue=false;Room1Lamp3.L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp3.L3IsGreen=false;Room1Lamp3.L3IsRed=true;
                Light3.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp4.L4IsBlue == true){Room1Lamp4.L4IsBlue=false;Room1Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp4.L4IsGreen=false;Room1Lamp4.L4IsRed=true;
                Light4.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp5.L5IsBlue == true){Room1Lamp5.L5IsBlue=false;Room1Lamp5.L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp5.L5IsGreen=false;Room1Lamp5.L5IsRed=true;
                Light5.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp6.L6IsBlue == true){Room1Lamp6.L6IsBlue=false;Room1Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp6.L6IsGreen=false;Room1Lamp6.L6IsRed=true;
                Light6.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp7.L7IsBlue == true){Room1Lamp7.L7IsBlue=false;Room1Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp7.L7IsGreen=false;Room1Lamp7.L7IsRed=true;
                Light7.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp8.L8IsBlue == true){Room1Lamp8.L8IsBlue=false;Room1Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp8.L8IsGreen=false;Room1Lamp8.L8IsRed=true;
                Light8.GetComponent<Animation>().Play("LightChangeGreenRed");}
           
                if(Room1Lamp9.L9IsBlue == true){Room1Lamp9.L9IsBlue=false;Room1Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeBlueGreen");
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}
                else{Room1Lamp9.L9IsGreen=false;Room1Lamp9.L9IsRed=true;
                Light9.GetComponent<Animation>().Play("LightChangeGreenRed");}
            }}

            }
    
    
}
