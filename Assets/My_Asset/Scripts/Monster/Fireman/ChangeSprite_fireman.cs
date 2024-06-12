using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite_fireman : MonoBehaviour
{
    [SerializeField] private GameObject[] cameraCharacter;
    [SerializeField] private Transform firemanPoint;
    [SerializeField] private float rangeAttack;
    [SerializeField] private LayerMask hero;
    [SerializeField] private SpriteRenderer firemanSprite;
    [SerializeField] private Sprite[] changeSprite;
    [SerializeField] private float timeDelay;
    public void ChangeStatus1()
    {
        cameraCharacter[0].SetActive(false);
        cameraCharacter[1].SetActive(true);
        firemanSprite.sprite = changeSprite[0];
        StartCoroutine(Delay());
    }

    public void ChangeStatus2()
    {
        cameraCharacter[0].SetActive(false);
        cameraCharacter[1].SetActive(true);
        firemanSprite.sprite = changeSprite[1];
        StartCoroutine(Delay());
    }
    private void BackHeroCamera()
    {
        cameraCharacter[0].SetActive(true);
        cameraCharacter[1].SetActive(false);
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(timeDelay);
        BackHeroCamera();
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(firemanPoint.position, rangeAttack);
    }
}
