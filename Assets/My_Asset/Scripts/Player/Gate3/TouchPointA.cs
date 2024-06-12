using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchPointA : MonoBehaviour
{
    [SerializeField] private TouchPointA touchA;
    [SerializeField] private Animator playAnim;
    [SerializeField] private Player_Move move;
    [SerializeField] private Rigidbody2D player;
    [SerializeField] private GameObject healthBar;
    [SerializeField] private ChangeSprite_fireman fireMan;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pointDis"))
        {
            player.velocity = Vector2.zero;
            move.enabled = false;
            playAnim.enabled = false;
            healthBar.SetActive(true);
            fireMan.ChangeStatus1();
            StartCoroutine(DelayDestroy());
        }
    }

    private void Destroy()
    {
        fireMan.BackHeroCamera();
        move.enabled = true;
        playAnim.enabled = true;
        Destroy(touchA);
    }
    private IEnumerator DelayDestroy()
    {
        yield return new WaitForSeconds(5);
        Destroy();
    }
    private void Update()
    {
        
    }
}
