using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectInteractionCanvaManager
{
 
    public static ObjectInteractionCanvaManager _instance = null;

    public static ObjectInteractionCanvaManager Instance()
    {
        if(_instance==null)
        {
            _instance= new ObjectInteractionCanvaManager();
        }

        Debug.Log("Singleton Works");
        return _instance;
    }

    public void DisableCanva(Canvas ObjectInteractionCanva)
    {
        ObjectInteractionCanva.gameObject.SetActive(false);
    }

    public void EnableCanva(Canvas ObjectInteractionCanva)
    {
        ObjectInteractionCanva.gameObject.SetActive(true);
    }
}
