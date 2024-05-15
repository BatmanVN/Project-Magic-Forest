using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DieBar : MonoBehaviour
{
    [SerializeField] private string sceneHome;
    [SerializeField] private string sceneSpawn;
    [SerializeField] private HealthCharacter character;
    [SerializeField] private GameObject dieBar;

    [SerializeField] private bool home;
    [SerializeField] private bool spawn;
    private void EnableDieBar()
    {
        dieBar.SetActive(true);
        Time.timeScale = 0;
    }
    public void EnableBar()
    {
        StartCoroutine(Delay());
    }
    private void ClickButton()
    {
        if (home)
        {
            SceneManager.LoadScene(sceneHome);
            Time.timeScale = 1;
        }
        if (spawn)
        {
            SceneManager.LoadScene(sceneSpawn);
            Time.timeScale = 1;
        }
    }
    public void HomeButton()
    {
        home = true;
    }
    public void ReSpwan()
    {
        spawn = true;
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(1.9f);
        EnableDieBar();
    }
    private void Update()
    {
        ClickButton();
    }
}
