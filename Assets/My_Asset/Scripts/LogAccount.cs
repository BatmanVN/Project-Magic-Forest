using GooglePlayGames.BasicApi;
using GooglePlayGames;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogAccount : MonoBehaviour
{
    public bool connectedToGooglePlay;
    void Start()
    {
        LoginToGooglePlay();
        Showleader();
    }

    // Update is called once per frame
    void Awake()
    {
        PlayGamesPlatform.Activate();
    }

    void LoginToGooglePlay()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthenticate);
    }


    private void ProcessAuthenticate(SignInStatus status)
    {
        Debug.Log("Login");
        if (status == SignInStatus.Success)
        {
            connectedToGooglePlay = true;
            Debug.Log("Login success");
        }
        connectedToGooglePlay = false;
    }
    private void Showleader()
    {
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkI0I_z7tAQEAIQAg");
    }
}
