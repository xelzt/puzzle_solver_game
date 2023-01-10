using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setActiveElement : MonoBehaviour
{
    [SerializeField]
    public GameObject gameObj;// Object to active/hide
    public Collider gameObjCollider;// Object to active/hide
    public bool activeMode;
    void Start()
    {
        PlayerPrefs.DeleteAll();
        if (gameObj.name == "Nexus")
        {
            gameObjCollider = GetComponent<Collider>();
        }
    }

    void Update()
    {
        if (PlayerPrefs.GetInt("DidElexQuest") == 1)
        {
            gameObj.SetActive(activeMode);
            if (gameObj.name == "Nexus")
            {
                gameObjCollider.enabled = true;
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("In trigger");
        }
    }
}
