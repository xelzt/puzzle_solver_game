using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PortalActivator : MonoBehaviour
{
    public Collider gameObjCollider;
    public Renderer gameObjRenderer;
    public bool inTriger;
    void Start()
    {
        gameObjCollider = GetComponent<Collider>();
        gameObjRenderer = GetComponent<Renderer>();
    }

    void Update()
    {
        if (Lamp1.LampBool1 && Lamp2.LampBool2 && Lamp3.LampBool3 && 
            Lamp4.LampBool4 && Lamp5.LampBool5 && Lamp6.LampBool6 &&
            Lamp7.LampBool7 && Lamp8.LampBool8 && Lamp9.LampBool9)
        {
            gameObjRenderer.enabled = true;
            gameObjCollider.enabled = true;
        }
        if (inTriger)
        {
            PlayerPrefs.SetInt("Lvl_1_Passed", 1);
            PlayerPrefs.Save();
            SceneManager.LoadScene("SceneSpaceShipLevel");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inTriger = true;
        }
        
    }
}
