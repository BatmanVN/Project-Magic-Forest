//using GooglePlayGames.BasicApi;
//using GooglePlayGames;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class SignIn : MonoBehaviour
//{
//    public bool connectedToGooglePlay;
//    void Awake()
//    {
//        PlayGamesPlatform.DebugLogEnabled = true;
//        PlayGamesPlatform.Activate();
//    }
//    void Start()
//    {
//        LoginGooglePlay();
//    }
//    void LoginGooglePlay()
//    {
//        PlayGamesPlatform.Instance.Authenticate(ProcessAuthentication);
//    }
//    void ProcessAuthentication(SignInStatus status)
//    {
//        if (status == SignInStatus.Success)
//        {
//            connectedToGooglePlay = true;
//        }
//        else connectedToGooglePlay = false;
//    }
//}
