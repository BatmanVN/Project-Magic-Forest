using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StopGround : MonoBehaviour
{
    [SerializeField] private Player_Move move;
    private bool stopGroundLeft;
    private bool stopGroundRight;

    public bool StopGroundLeft { get => stopGroundLeft; set => stopGroundLeft = value; }
    public bool StopGroundRight { get => stopGroundRight; set => stopGroundRight = value; }

    private void OnTriggerEnter2D(Collider2D Player)
    {
        if (Player.CompareTag("StopGround"))
        {
            move.IsLeft = false;
            stopGroundLeft = true;
        }
        if (Player.CompareTag("StopGroundRight"))
        {
            move.IsLeft = false;
            stopGroundRight = true;
        }
    }
    private void OnTriggerExit2D(Collider2D Player)
    {
        if (Player.CompareTag("StopGround"))
        {
            StopGroundLeft = false;
        }
        if (Player.CompareTag("StopGroundRight"))
        {
            StopGroundRight = false;
        }
    }
    private void Update()
    {
        
    }
}
