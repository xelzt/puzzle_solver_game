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
    public Canvas[] DisablingCanvas;
    [SerializeField]
    public string PlayerPrefsKey;
    [SerializeField]
    public GameObject MeshRendererObjectCheck;


    private Rigidbody Player;
    private Text Textbox;
    private bool IsComponentUsingRigidbody;
    private Rigidbody ObjectRigidbody;
    private bool DisableCanva = false;
    private int PlayerPrefVariable;
    private bool MeshRendererBasedCheck = false;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        ObjectInteractionInfoCanva = Instantiate(ObjectInteractionInfoCanva).GetComponent<Canvas>();
        Textbox = ObjectInteractionInfoCanva.gameObject.GetComponentInChildren<Text>();
        IsComponentUsingRigidbody = this.gameObject.TryGetComponent(out Rigidbody rb);
        if (IsComponentUsingRigidbody) { ObjectRigidbody = this.gameObject.GetComponent<Rigidbody>(); }
        if (MeshRendererObjectCheck) { MeshRendererBasedCheck = true; }
        Textbox.text = DisplayText;


    }

    private void DisplayForRigidBodyObjects()
    {
        bool CanvaStatus = (ObjectRigidbody.useGravity && CheckIfPlayerIsCloseToObject() && !DisableCanva && PlayerPrefVariable != 1);
        ObjectInteractionInfoCanva.gameObject.SetActive(CanvaStatus);
    }

    private void DisplayForNonRigidBodyObjects()
    {
        bool CanvaStatus = (CheckIfPlayerIsCloseToObject() && !DisableCanva && PlayerPrefVariable != 1);
        ObjectInteractionInfoCanva.gameObject.SetActive(CanvaStatus);
    }

    private bool CheckIfPlayerIsCloseToObject()
    {
        var PlayerPosition = (this.transform.position - Player.position).magnitude;
        return (PlayerPosition < 2.5f);
    }

    private void CheckIfCanvaShouldBeEnabled()
    {
        foreach (Canvas c in DisablingCanvas)
        {
            if (c.gameObject.activeInHierarchy)
            {
                DisableCanva = true;
                break;
            }
            else
            {
                DisableCanva = false;
            }
        }
    }

    void Update()
    {
        PlayerPrefVariable = PlayerPrefs.GetInt(PlayerPrefsKey);
        CheckIfCanvaShouldBeEnabled();
        if (MeshRendererBasedCheck) 
        { 
            var x = MeshRendererObjectCheck.gameObject.GetComponent<MeshRenderer>().enabled; 
            if (x)
            {
                (IsComponentUsingRigidbody.Equals(true) ? (Action)DisplayForRigidBodyObjects : DisplayForNonRigidBodyObjects)();
            }
        }
        else
        {
            (IsComponentUsingRigidbody.Equals(true) ? (Action)DisplayForRigidBodyObjects : DisplayForNonRigidBodyObjects)();
        }

    }
}
