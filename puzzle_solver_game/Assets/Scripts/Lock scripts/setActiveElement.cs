using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveElement : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObj;// Object to active/hide
    public Collider gameObjCollider;// Object to active/hide
    public Renderer gameObjRenderer;// Object to active/hide
    public bool activeMode;
    public bool setObjectStatus;
    void Start()
    {
        PlayerPrefs.DeleteAll();
        if (gameObj.name == "Nexus" | gameObj.name == "Nexus_to_input")
        {
            gameObjCollider = GetComponent<Collider>();
            gameObjRenderer = GetComponent<Renderer>();
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("DidElexQuest") == 1 && !setObjectStatus)
        {
            gameObj.SetActive(activeMode);
            if (gameObj.name == "Nexus_to_input")
            {
                gameObjCollider.enabled = true;
            }
            else if(gameObj.name == "Nexus")
            {
                gameObjCollider.enabled = true;
                gameObjRenderer.enabled = true;
            }
            setObjectStatus = true;
        }
    }
}
