using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointKnight : MonoBehaviour
{
    [SerializeField] private Health healths;
    [SerializeField] private TotalScore score;
    [SerializeField] private string pointName;
    [SerializeField] private int point;
    private bool takenPoint;

    [ContextMenu("SavePoint")]
    private void GetPoint()
    { 
            if(healths.isDead)
            {
                if (takenPoint == false)
                {
                    score.PointGet += 1;
                    takenPoint = true;
                    PlayerPrefs.SetInt(pointName, score.PointGet);
                }
            }
    }
    private void Update()
    {
        point = score.PointGet;
        GetPoint();
    }
}
