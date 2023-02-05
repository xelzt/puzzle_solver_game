using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class LightsScript : MonoBehaviour
{
    public GameObject Light1;
    public GameObject Light2;
    public GameObject Light3;
    public GameObject Light4;
    public GameObject Light5;
    public GameObject Light6;
    public GameObject Light7;
    public GameObject Light8;
    public GameObject Light9;

    public bool Action;
    bool M0 = true;
     bool M1 = false;
     bool M2 = false;
     bool M3 = false;
     bool M4 = false;
     bool M5 = false;
     bool M6 = false;
     bool M7 = false;

    [SerializeField]
    GameObject shard_to_blink;

      void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Action = true;
        }
    }
    void OnTriggerExit(Collider collision)
    {
        Action = false;
    }
   
    async void Update()
    {
  
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Action==true && M0==true)
            {
                Light1.GetComponent<Animation>().Play("Light1F");
                M0=false;
                M1=true;
            }
        }

        if (M1==true && Mirror1.M1==true){
            M1 = false;
            Mirror1.Bloced = false;
            await Task.Delay(1000);
            Light2.GetComponent<Animation>().Play("Light2F");
            M2 = true;

        }

        if (M2==true && Mirror2.M2==true){
            M2 = false;
            Mirror2.Bloced = false;
            await Task.Delay(1000);
            Light3.GetComponent<Animation>().Play("Light3F");
            M3 = true;

        }


        if (M3==true && Mirror3.M3==true){
            M3 = false;
            Mirror3.Bloced = false;
            await Task.Delay(1000);
            Light4.GetComponent<Animation>().Play("Light4F");
            M4 = true;

        }

        if (M4==true && Mirror4.M4==true){
            M4 = false;
            Mirror4.Bloced = false;
            await Task.Delay(1000);
            Light5.GetComponent<Animation>().Play("Light5F");
            M5 = true;
        }

        if (M5==true && Mirror5.M5==true){
            M5 = false;
            Mirror5.Bloced = false;
            await Task.Delay(1000);
            Light6.GetComponent<Animation>().Play("Light6F");
            M6 = true;
        }

        if (M6==true && Mirror6.M6==true){
            M6 = false;
            Mirror6.Bloced = false;
            await Task.Delay(1000);
            Light7.GetComponent<Animation>().Play("Light7F");
            M7 = true;
        }

        if (M7==true && Mirror7.M7==true){
             M7=false;
             Mirror7.Bloced=false;
             await Task.Delay(1000);
             Light8.GetComponent<Animation>().Play("Light8F");
             await Task.Delay(1000);
             Light9.GetComponent<Animation>().Play("Light9F");
             shard_to_blink.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
        }
}
}
           
            

        
    
