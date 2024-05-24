using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignius_GetData : MonoBehaviour
{   
    [SerializeField] private string healthName;
    [SerializeField] private string powerName;
    [SerializeField] private string speedName;
    [SerializeField] private string starName;
    [SerializeField] private float value;
    [ContextMenu("GetData")]
    private float GetData()
    {
        value = PlayerPrefs.GetFloat(healthName, value);
        value = PlayerPrefs.GetFloat(powerName, value);
        value = PlayerPrefs.GetFloat (speedName, value);
        value = PlayerPrefs.GetFloat(starName, value);
        return value;
    }

}
