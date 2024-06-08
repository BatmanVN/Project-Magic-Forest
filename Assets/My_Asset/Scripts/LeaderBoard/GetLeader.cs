using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetLeader : MonoBehaviour
{
    [SerializeField] private string getScore;
    [SerializeField] private int score;

    public int Score { get => score; set => score = value; }

    private int GetScore()
    {
        score = PlayerPrefs.GetInt(getScore, score);
        return score;
    }
    private void Start()
    {
        GetScore();
    }
}
