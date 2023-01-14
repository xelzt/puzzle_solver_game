using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp1 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool1 = false;
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light4;
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
                if(LampBool1==false){LampBool1=true;
                Light1.GetComponent<Animation>().Play("LightChange");
                }else{LampBool1=false;
                Light1.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp2.LampBool2==false){Lamp2.LampBool2=true;
                Light2.GetComponent<Animation>().Play("LightChange");
                }else{Lamp2.LampBool2=false;
                Light2.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp4.LampBool4==false){Lamp4.LampBool4=true;
                Light4.GetComponent<Animation>().Play("LightChange");
                }else{Lamp4.LampBool4=false;
                Light4.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
