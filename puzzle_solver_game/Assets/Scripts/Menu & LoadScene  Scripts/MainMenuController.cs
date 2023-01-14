using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject LoadGamePanel;
    public GameObject secondLvlButton;
    private Button btn;
    public float transitionTime = 1f;

    private void Start()
    {
        btn = secondLvlButton.GetComponent<Button>();
        btn.interactable = (PlayerPrefs.GetInt("Lvl_1_Passed") == 1 && !btn.interactable) ? true : false;
    }
    public void openSelectLevel()
    {
        LoadGamePanel.SetActive(true);
    }
    public void closeSelectLevel()
    {
        LoadGamePanel.SetActive(false);
    }
    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
