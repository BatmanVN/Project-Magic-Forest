using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderGetPoint : MonoBehaviour
{
    [SerializeField] private string pointGet;
    [SerializeField] private int getPoint;

    public int GetPoint { get => getPoint; set => getPoint = value; }

    [ContextMenu("GetPoint")]

    private int GetScore()
    {
        GetPoint = PlayerPrefs.GetInt(pointGet,getPoint);
        return GetPoint;
    }
    private void Start()
    {
        GetScore();
    }
}
