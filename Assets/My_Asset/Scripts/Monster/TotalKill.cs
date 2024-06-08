using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalKill : MonoBehaviour
{
    [SerializeField] private string getSaveScore;
    [SerializeField] private int score;

    public int Score { get => score; set => score = value; }

    [ContextMenu("GetScore")] 
    private int GetScore()
    {
        score = PlayerPrefs.GetInt(getSaveScore, score);
        return score;
    }
    private void Start()
    {
        GetScore();
    }
}
