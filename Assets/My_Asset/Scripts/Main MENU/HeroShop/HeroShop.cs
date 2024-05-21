using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroShop : MonoBehaviour
{
    [SerializeField] private GameObject indexBar;
    [SerializeField] private GameObject noteIndex;
    [SerializeField] private GameObject xButton;
    [SerializeField] private GameObject noteButton;



    public void EnableNote()
    {
        noteButton.SetActive(false);
        indexBar.SetActive(false);
        noteIndex.SetActive(true);
        xButton.SetActive(true);
    }
    public void DissableNote()
    {
        xButton.SetActive(false);
        noteIndex.SetActive(false);
        indexBar.SetActive(true);
        noteButton.SetActive(true);
    }
    public void BackMenu(string name)
    {
        SceneManager.LoadScene(name);
    }
    private void Update()
    {
        
    }

}
