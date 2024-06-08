using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointSke : MonoBehaviour
{
    [SerializeField] private string score;
    [SerializeField] private TotalKill getScore;
    [SerializeField] private Health skeHealth;
    private bool takedScore;

    [ContextMenu("SaveScore")]
    private void TakeScore()
    {
        if(skeHealth.isDead)
        {
            if(takedScore == false)
            {
                getScore.Score += 5;
                takedScore = true;
                PlayerPrefs.SetInt(score, getScore.Score);
                if (Social.localUser.authenticated == true)
                {
                    Social.ReportScore(getScore.Score, GPGSIds.leaderboard_monster_slayer, (bool success) =>
                    {

                    });
                }
                else
                {
                    return;
                }
            }
        }
    }
    private void Update()
    {
        TakeScore();
    }
}
