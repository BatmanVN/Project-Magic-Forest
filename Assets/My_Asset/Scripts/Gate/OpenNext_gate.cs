using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNext_gate : MonoBehaviour
{
    [SerializeField] private GameObject[] gateOpen;
    [SerializeField] private GameObject[] gateClose;
    [SerializeField] private string[] gateName;
    [SerializeField] private int gateNumber;
    [SerializeField] private bool open;
public bool Open { get => open; set => open = value; }

    [ContextMenu("GetGate")]
    private void OpenGate()
    {
        for (int i = 0; i < gateOpen.Length; i++)
        {
            if (gateNumber == 1)
            {
                gateOpen[0].SetActive(true);
                gateClose[0].SetActive(false);
            }
            if (gateNumber == 2)
            {
                gateOpen[1].SetActive(true);
                gateClose[1].SetActive(false);
            }
            open = true;
        }
    }
    private int GetGate()
    {
        for(int i = 0; i < gateName.Length;i++)
        {
            gateNumber = PlayerPrefs.GetInt(gateName[i], gateNumber);
        }
        return gateNumber;
    }
    private void Start()
    {
        GetGate();
    }
    private void Update()
    {
        OpenGate();
    }
}
