using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Choose_Gate : MonoBehaviour
{
    public void ChooseGate(string gateName)
    {
        SceneManager.LoadScene(gateName);
    }
    private void Update()
    {

    }
}
