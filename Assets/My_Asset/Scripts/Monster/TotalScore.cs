using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalScore : MonoBehaviour
{
    [SerializeField] private string pointName;
    [SerializeField] private int pointGet;

    public int PointGet { get => pointGet; set => pointGet = value; }

    [ContextMenu("Getpoint")]

    private int GetScore()
    {
        PointGet = PlayerPrefs.GetInt(pointName, PointGet);
        return PointGet;
    }
    private void Update()
    {
        GetScore();
    }
}
