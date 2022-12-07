using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp7 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool7 = false;
    public GameObject Light4;
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
                if(LampBool7==false){LampBool7=true;
                Light7.GetComponent<Animation>().Play("LightChange");
                }else{LampBool7=false;
                Light7.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp4.LampBool4==false){Lamp4.LampBool4=true;
                Light4.GetComponent<Animation>().Play("LightChange");
                }else{Lamp4.LampBool4=false;
                Light4.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp8.LampBool8==false){Lamp8.LampBool8=true;
                Light8.GetComponent<Animation>().Play("LightChange");
                }else{Lamp8.LampBool8=false;
                Light8.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
