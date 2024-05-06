using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogGame : MonoBehaviour
{
    [SerializeField] private string sceneName;
    public bool logIn;
    public void LoginGame()
    {
        logIn = true;
    }
    private void StartGame()
    {
        if(logIn == true)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    private void Update()
    {
        StartGame();
    }
}
