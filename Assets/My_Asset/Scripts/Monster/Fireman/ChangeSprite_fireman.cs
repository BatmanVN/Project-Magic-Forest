using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite_fireman : MonoBehaviour
{
    [SerializeField] private Player_Move speed;
    [SerializeField] private GameObject[] cameraCharacter;
    [SerializeField] private SpriteRenderer firemanSprite;
    [SerializeField] private Sprite[] changeSprite;
    [SerializeField] private float timeDelay;

    public void ChangeStatus1()
    {
        cameraCharacter[0].SetActive(false);
        cameraCharacter[1].SetActive(true);
        firemanSprite.sprite = changeSprite[0];
    }

    public void ChangeStatus2()
    {
        cameraCharacter[0].SetActive(false);
        cameraCharacter[1].SetActive(true);
        firemanSprite.sprite = changeSprite[1];
    }
    public void BackHeroCamera()
    {
        cameraCharacter[0].SetActive(true);
        cameraCharacter[1].SetActive(false);
    }
}
