using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private GameObject pauseObj;

    public void EnablePauseBar()
    {
        pauseObj.SetActive(true);
        Time.timeScale = 0f;
    }
    public void ButtonBar(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Time.timeScale = 1f;
    }
    public void ContinueGame()
    {
        pauseObj.SetActive(false); 
        Time.timeScale = 1f;
    }
}
