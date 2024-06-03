using GooglePlayGames;
using GooglePlayGames.BasicApi;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignIn : MonoBehaviour
{
    public bool connectedToGooglePlay;

    void Start()
    {
        LoginToGooglePlay();
    }
    void LoginToGooglePlay()
    {
        PlayGamesPlatform.Instance.Authenticate(ProcessAuthenticate);
        PlayGamesPlatform.Activate();
    }
    private void ProcessAuthenticate(SignInStatus status)
    {
        if (status == SignInStatus.Success)
        {
            connectedToGooglePlay = true;
            Debug.Log("Login success");
        }
        connectedToGooglePlay = false;
    }
}
