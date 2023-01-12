using UnityEngine;
using UnityEngine.UI;

public class PossibleObjectInteractionInfo : MonoBehaviour
{

    [SerializeField]
    public string DisplayText;
    private Rigidbody Player;
    public Canvas ObjectInteractionInfoCanva;
    private Text Textbox;
    private bool IsComponentUsingRigidbody;
    private Rigidbody ObjectRigidbody;
    public Canvas[] DisablingCanvas;
    private bool DisableCanva = false;

    private void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        ObjectInteractionInfoCanva = Instantiate(ObjectInteractionInfoCanva).GetComponent<Canvas>();
        Textbox = ObjectInteractionInfoCanva.gameObject.GetComponentInChildren<Text>();
        IsComponentUsingRigidbody = this.gameObject.TryGetComponent(out Rigidbody rb);
        if (IsComponentUsingRigidbody) { ObjectRigidbody = this.gameObject.GetComponent<Rigidbody>(); }
        Textbox.text = DisplayText;

    }

    private void DisplayForRigidBodyObjects()
    {
        if (ObjectRigidbody.useGravity && CheckIfPlayerIsCloseToObject() && !DisableCanva)
        {
            ObjectInteractionInfoCanva.gameObject.SetActive(true);
        }
        else
        {
            ObjectInteractionInfoCanva.gameObject.SetActive(false);
        }
    }

    private void DisplayForNonRigidBodyObjects()
    {
        if (CheckIfPlayerIsCloseToObject() && !DisableCanva)
        {
            ObjectInteractionInfoCanva.gameObject.SetActive(true);
        }
        else
        {
            ObjectInteractionInfoCanva.gameObject.SetActive(false);
        }
    }

    private bool CheckIfPlayerIsCloseToObject()
    {
        var PlayerPosition = (this.transform.position - Player.position).magnitude;
        if (PlayerPosition < 2f)
        {

            return true;
        }
        else
        {
            return false;
        }
    }

    [System.Obsolete]
    void Update()
    {
        foreach(Canvas c in DisablingCanvas)
        {
            if(c.gameObject.active)
            {
                DisableCanva = true;
                break;
            }
            else
            {
                DisableCanva = false;
            }
        }

        if (IsComponentUsingRigidbody)
        {
            DisplayForRigidBodyObjects();
        }
        else
        {
            DisplayForNonRigidBodyObjects();
        }
        
    }
}
