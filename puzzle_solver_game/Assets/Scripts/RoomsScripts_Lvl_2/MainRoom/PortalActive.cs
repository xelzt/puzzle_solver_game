using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalActive : MonoBehaviour
{
    public GameObject portal;
    public GameObject shard1;
    public GameObject shard2;
    public GameObject shard3;
    public GameObject shard4;
    public bool inTriger;


    void Update()
    {
        checkShardColor();
        if (inTriger)
        {
            PlayerPrefs.SetInt("Lvl_2_Passed", 1);
            PlayerPrefs.Save();
            LevelLoader.Instance.ChangeScene("SceneToBeAddedLevel");
        }
    }

    private void checkShardColor()
    {
        if (shard1.GetComponent<ColorChanger>().colorChanged == true &&
            shard2.GetComponent<ColorChanger>().colorChanged == true &&
            shard3.GetComponent<ColorChanger>().colorChanged == true &&
            shard4.GetComponent<ColorChanger>().colorChanged == true)
        {
            portal.GetComponent<Renderer>().enabled = true;
            portal.GetComponent<Collider>().enabled = true;
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
 