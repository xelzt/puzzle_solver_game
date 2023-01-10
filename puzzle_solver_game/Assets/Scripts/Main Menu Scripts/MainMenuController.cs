using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Animator transition;
    public GameObject LoadGamePanel;
    public float transitionTime = 1f;

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
        Debug.Log("quited");
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
