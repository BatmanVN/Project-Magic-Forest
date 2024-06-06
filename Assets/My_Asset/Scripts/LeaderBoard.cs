using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoard : MonoBehaviour
{
    //private void Start()
    //{
    //    Showleader();
    //}
    public void Showleader()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI0I_z7tAQEAIQAg");
    }
}
