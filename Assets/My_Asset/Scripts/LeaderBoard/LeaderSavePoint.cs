using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class LeaderSavePoint : MonoBehaviour
{
    [SerializeField] private string pointName;
    [SerializeField] private int pointScore;
    [SerializeField] private LeaderGetPoint getPoint;

    [ContextMenu("SavePoint")]

    private void Update()
    {
        pointScore = getPoint.GetPoint;
        GetPoint();
    }
    private void Start()
    {
        //GetPoint();
    }

    private void GetPoint()
    {
        PlayerPrefs.SetInt(pointName, getPoint.GetPoint);
    }
    public void Showleader()
    {
        Social.ReportScore(pointScore, GPGSIds.leaderboard_kill_knight, (bool success) =>
        {
            success = true;
        });
    }
}
