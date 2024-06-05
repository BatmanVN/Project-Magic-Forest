using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fence_Tree : MonoBehaviour
{
    [SerializeField] private GameObject fenceObj;
    [SerializeField] private GameObject destroyEffect;
    [SerializeField] private SpriteRenderer destroyRender;
    [SerializeField] private Animator destroyAnim;
    [SerializeField] private float delay;
    public bool isDestroy;
    private void OnTriggerEnter2D(Collider2D fence)
    {
         if(fence.CompareTag("FireBall"))
        {
            fenceObj.gameObject.SetActive(false);
            destroyRender.enabled = true;
            destroyAnim.SetTrigger("isDestroy");
            StartCoroutine(Delay());
        }
    }
    private void DestroyFence()
    {
         destroyEffect.SetActive(false);
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(delay);
        DestroyFence();
    }
}
