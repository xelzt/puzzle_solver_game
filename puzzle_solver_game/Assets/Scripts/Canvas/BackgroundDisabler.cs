using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundDisabler : MonoBehaviour
{
    public Canvas[] DisableCanvas;

    // Update is called once per frame
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

    private bool CheckIfOneOfCanvaIsActive()
    {
        foreach(Canvas c in DisableCanvas)
        {
            if (c.gameObject.activeInHierarchy)
            {
                return true;
            }
        }

        return false;
    }
}
