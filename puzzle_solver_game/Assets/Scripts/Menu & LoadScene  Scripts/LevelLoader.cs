using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitionTime = 1f;
    public static LevelLoader Instance;
    private void Awake()
    {
        Instance = this;
    }
    public void ChangeScene(string sceneName)
    {
        StartCoroutine(loadLevel(sceneName));
    }

    IEnumerator loadLevel(string levelName)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelName);
    }
}
