using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run_Animation : MonoBehaviour
{
    [SerializeField] private Player_Move playerMove;
    [SerializeField] private GameObject runObj;

    public void EnableRunAnim()
    {
        if(playerMove.isRunning == true)
        {
            runObj.SetActive(true);
        }
        else
        {
            runObj.SetActive(false);
        }
    }
    private void Update()
    {
        
    }
}
