using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
using UnityEngine.UI;

public class PossibleObjectInteractionInfo : MonoBehaviour
{

    [SerializeField]
    public string DisplayText;
    [SerializeField]
    public Canvas ObjectInteractionInfoCanva;
    [SerializeField]
    public GameObject[] ConflictingObjects;
    [SerializeField]
    public string PlayerPrefsKey;
    [SerializeField]
    public int ExpectedPlayerPrefsValue = 0;


    private Text Textbox;
    private bool IsComponentUsingRigidbody;
    private Rigidbody ObjectRigidbody;
    private bool DisableCanva = false;
    private int PlayerPrefVariable;
    private Canvas ObjectInteractionInfoCanvaCopy;
    private bool CollisionWithObject;
    private Rigidbody Player;

    private void Awake()
    {
        IsComponentUsingRigidbody = this.gameObject.TryGetComponent(out Rigidbody rb);
        if (IsComponentUsingRigidbody) { ObjectRigidbody = this.gameObject.GetComponent<Rigidbody>(); }
        ObjectInteractionInfoCanvaCopy = ObjectInteractionInfoCanva.GetComponent<Canvas>();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    private void DisplayForRigidBodyObjects()
    {
        bool CanvaStatus = (ObjectRigidbody.useGravity && !DisableCanva);
        bool IsCanvaActiveInHierarchy = ObjectInteractionInfoCanva.gameObject.activeInHierarchy;
        if (CanvaStatus) 
        {
            if(!IsCanvaActiveInHierarchy)
            {
                CreateCanvaObject();
                ObjectInteractionInfoCanva.gameObject.SetActive(true);
            }
            
        }
        else
        {
            if(IsCanvaActiveInHierarchy)
            {
                ObjectInteractionInfoCanva.gameObject.SetActive(false);
                DestroyCanvaObject();
            }
        }
    }

    private void DisplayForNonRigidBodyObjects()
    {
        bool CanvaStatus = (IsPuzzleSolved() && !DisableCanva);
        ObjectInteractionInfoCanva.gameObject.SetActive(CanvaStatus);
    }

    private bool IsPuzzleSolved()
    {
        return PlayerPrefVariable == ExpectedPlayerPrefsValue;
    }

    private bool AreConflictingObjectsEnabled()
    {
        foreach (GameObject go in ConflictingObjects)
        {
            if (go.activeInHierarchy) { return true; }
        }
        return false;
    }

    private void Update()
    {
        if (CollisionWithObject)
        {
            PlayerPrefVariable = PlayerPrefs.GetInt(PlayerPrefsKey);
            DisableCanva = AreConflictingObjectsEnabled();
            DisplayForNonRigidBodyObjects();
        }

        if(IsComponentUsingRigidbody)
        {
            float object_player_distance = (this.transform.position - Player.position).magnitude;
            DisableCanva = !(object_player_distance < 2f);
            DisplayForRigidBodyObjects();
        }
    }

    private void CreateCanvaObject()
    {
        CollisionWithObject = true;
        ObjectInteractionInfoCanva = Instantiate(ObjectInteractionInfoCanva).GetComponent<Canvas>();
        Textbox = ObjectInteractionInfoCanva.gameObject.GetComponentInChildren<Text>();
        Textbox.text = DisplayText;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Player")){ CreateCanvaObject(); }
    }

    private void DestroyCanvaObject()
    {
        CollisionWithObject = false;
        Destroy(ObjectInteractionInfoCanva.gameObject, 0.2f);
        ObjectInteractionInfoCanva = ObjectInteractionInfoCanvaCopy;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") { DestroyCanvaObject(); }
    }
}
