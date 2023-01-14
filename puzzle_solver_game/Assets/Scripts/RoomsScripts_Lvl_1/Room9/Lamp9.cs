using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamp9 : MonoBehaviour
{
    public bool Action;
    [SerializeField]
    public static bool LampBool9 = false;

    public GameObject Light6;
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
                if(LampBool9==false)
                {
                    LampBool9=true;
                    Light9.GetComponent<Animation>().Play("LightChange");
                }else
                {
                    LampBool9=false;
                    Light9.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp6.LampBool6==false)
                {
                    Lamp6.LampBool6=true;
                    Light6.GetComponent<Animation>().Play("LightChange");
                }else{
                    Lamp6.LampBool6=false;
                    Light6.GetComponent<Animation>().Play("LightChangeBack");
                }
                if(Lamp8.LampBool8==false)
                {
                    Lamp8.LampBool8=true;
                    Light8.GetComponent<Animation>().Play("LightChange");
                }else{
                    Lamp8.LampBool8=false;
                    Light8.GetComponent<Animation>().Play("LightChangeBack");
                }
            }
        }
    }
}
