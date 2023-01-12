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
    
    void Update()
    {
     if  (
    shard1.GetComponent<ColorChanger>().colorChanged == true  &&
    shard2.GetComponent<ColorChanger>().colorChanged == true  &&
    shard3.GetComponent<ColorChanger>().colorChanged == true  &&
    shard4.GetComponent<ColorChanger>().colorChanged == true  
    ){
       portal.GetComponent<MeshRenderer>().enabled = true;
    }
    }
}
 