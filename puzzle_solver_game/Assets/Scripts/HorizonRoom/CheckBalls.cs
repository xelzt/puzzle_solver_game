using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBalls : MonoBehaviour
{
    public GameObject SuccessLight;
    public GameObject Ball1;
    public GameObject Ball2;
    public GameObject Ball3;
    public GameObject Ball4;
    private bool AnimStop = false;
    
   [SerializeField]
    GameObject shard_to_blink;
        
    void Update()
    {
        if(Ball1.GetComponent<RotateBall>().rotationCount == 3 &&
        Ball2.GetComponent<RotateBall>().rotationCount == 1 &&
        Ball3.GetComponent<RotateBall>().rotationCount == 2 &&
        Ball4.GetComponent<RotateBall>().rotationCount == 1){
        shard_to_blink.GetComponent<ColorChanger>().ChangeShardColour(Color.green);
        if(AnimStop==false){
        SuccessLight.GetComponent<Animation>().Play("SuccessLightAnim"); 
        AnimStop = true;
        }
        
    }
}
}