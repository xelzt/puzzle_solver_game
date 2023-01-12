using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public Animator transition;
    public GameObject LoadGamePanel;
    public GameObject secondLvlButton;
    private Button btn;
    public float transitionTime = 1f;

    private void Start()
    {
        btn = secondLvlButton.GetComponent<Button>();
        if (PlayerPrefs.GetInt("Lvl_1_Passed") == 1  && !btn.interactable)
        {
            btn.interactable = true;
        }
    }
    public void openSelectLevel()
    {
        LoadGamePanel.SetActive(true);
    }
    public void closeSelectLevel()
    {
        LoadGamePanel.SetActive(false);
    }

    public void loadFirstLvl()
    {
        SceneManager.LoadScene("SceneDungeonLevel");
    }

    public void loadSecondLvl()
    {
        SceneManager.LoadScene("SceneSpaceShipLevel");
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene("SceneMainMenu");
    }
    public void Quit()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
