using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp3 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool3 = false;
    public GameObject Light2;
    public GameObject Light3;
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
                if(LampBool3==false){LampBool3=true;
                Light3.GetComponent<Animation>().Play("LightChange");
                }else{LampBool3=false;
                Light3.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp2.LampBool2==false){Lamp2.LampBool2=true;
                Light2.GetComponent<Animation>().Play("LightChange");
                }else{Lamp2.LampBool2=false;
                Light2.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp6.LampBool6==false){Lamp6.LampBool6=true;
                Light6.GetComponent<Animation>().Play("LightChange");
                }else{Lamp6.LampBool6=false;
                Light6.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
