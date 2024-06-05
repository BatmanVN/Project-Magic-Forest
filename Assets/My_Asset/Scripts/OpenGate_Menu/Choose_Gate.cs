using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Choose_Gate : MonoBehaviour
{
    [SerializeField] private OpenNext_gate[] gate;
    public void ChooseGate(string gateName)
    {
        for (int i = 0; i < gate.Length; i++)
        {
            if (gate[i].Open == true)
            {
                SceneManager.LoadScene(gateName);
            }
        }
    }
    private void Update()
    {

    }
}
