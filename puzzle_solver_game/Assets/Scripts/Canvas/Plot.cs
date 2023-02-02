using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Plot : MonoBehaviour
{
    public GameObject PlotObj;
    private List<string> plot_lines= new List<string>();
    private Text plot_text;
    // Start is called before the first frame update
    void Start()
    {
        plot_text = PlotObj.GetComponentInChildren<Text>();
        plot_text.color = new Color(plot_text.color.r, plot_text.color.g, plot_text.color.b, 0);
        PlotObj.gameObject.SetActive(true);
        plot_lines.Add("After the battle you fought you were trying to escape from danger...");
        plot_lines.Add("Unfortunately it is not so easy to escape from the void...");
        plot_lines.Add("You thought you would back home safe, didn't you...?");
        plot_lines.Add("But the journey is just beginning...");
        StartCoroutine(DisplayLine());
    }

    private IEnumerator DisplayLine()
    {
        foreach (string line in plot_lines)
        {
            plot_text.text = line;
            StartCoroutine(FadeTextIn());
            yield return new WaitForSeconds(5);
            StartCoroutine(FadeTextOut());
            yield return new WaitForSeconds(2);
        }

        var cg = this.GetComponent<CanvasGroup>();
        StartCoroutine(FadeCanvasOut(cg));
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);

    }

    private IEnumerator FadeTextIn() 
    {
        while(plot_text.color.a < 1)
        {
            plot_text.color = new Color(plot_text.color.r, plot_text.color.g, plot_text.color.b, plot_text.color.a + (1f * Time.deltaTime)/3);
            yield return null;
        }
    }
    private IEnumerator FadeTextOut() 
    {
        while (plot_text.color.a > 0)
        {
            plot_text.color = new Color(plot_text.color.r, plot_text.color.g, plot_text.color.b, plot_text.color.a - (1f * Time.deltaTime)/3);
            yield return null;
        }
    }

    private IEnumerator FadeCanvasOut(CanvasGroup cg)
    {
        while (cg.alpha > 0)
        {
            cg.alpha = cg.alpha - (1f * Time.deltaTime) / 3;
            yield return null;
        }
    }


}
