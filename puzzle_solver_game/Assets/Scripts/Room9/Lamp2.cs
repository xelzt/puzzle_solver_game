using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp2 : MonoBehaviour
{
    public bool Action;
    public static bool LampBool2 = false;

    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light5;

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
                if(LampBool2==false){LampBool2=true;
                Light2.GetComponent<Animation>().Play("LightChange");
                }else{LampBool2=false;
                Light2.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp1.LampBool1==false){Lamp1.LampBool1=true;
                Light1.GetComponent<Animation>().Play("LightChange");
                }else{Lamp1.LampBool1=false;
                Light1.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp3.LampBool3==false){Lamp3.LampBool3=true;
                Light3.GetComponent<Animation>().Play("LightChange");
                }else{Lamp3.LampBool3=false;
                Light3.GetComponent<Animation>().Play("LightChangeBack");}
                if(Lamp5.LampBool5==false){Lamp5.LampBool5=true;
                Light5.GetComponent<Animation>().Play("LightChange");
                }else{Lamp5.LampBool5=false;
                Light5.GetComponent<Animation>().Play("LightChangeBack");}

            }
        }
    }
}
