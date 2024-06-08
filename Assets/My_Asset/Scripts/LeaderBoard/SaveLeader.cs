using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLeader : MonoBehaviour
{
    [SerializeField] private string saveScore;
    [SerializeField] private GetLeader getScore;
    
    [ContextMenu("SaveScore")]

    private void SaveScore()
    {
        PlayerPrefs.SetInt(saveScore, getScore.Score);
    }
    private void Update()
    {
        SaveScore();
    }
}
