using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDisabler : MonoBehaviour
{
    public Canvas[] DisableCanvas;

    // Update is called once per frame
    [System.Obsolete]
    void Update()
    {
        if(CheckIfOneOfCanvaIsActive())
        {
            this.gameObject.SetActive(false);
        }
        else
        {
            this.gameObject.SetActive(true);
        }
    }

    [System.Obsolete]
    private bool CheckIfOneOfCanvaIsActive()
    {
        foreach(Canvas c in DisableCanvas)
        {
            if (c.gameObject.activeSelf)
            {
                return true;
            }
        }

        return false;
    }
}
