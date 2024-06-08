using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointKnight : MonoBehaviour
{
    [SerializeField] private string saveScore;
    [SerializeField] private TotalKill getScore;
    [SerializeField] private Health knightHealth;
    private bool takedScore;

    [ContextMenu("SaveScore")]
    private void TakeScore()
    {
        if(knightHealth.isDead)
        {
            if(takedScore == false)
            {
                getScore.Score += 1;
                takedScore = true;
                PlayerPrefs.SetInt(saveScore, getScore.Score);
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
