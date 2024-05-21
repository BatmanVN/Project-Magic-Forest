using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] spriteRenderers;
    [SerializeField] private SpriteRenderer characterSprite;
    [SerializeField] private PlayerPrefsIntReader playerPrefsIntReader;
    [SerializeField] private int index;
    public void ChooseSprite()
    {
        if(index >=0 && index < spriteRenderers.Length)
        {
            characterSprite.sprite = spriteRenderers[index];
        }
        else
        {
            return;
        }
    }
    private void Update()
    {
        ChooseSprite();
    }
    private void Start()
    {
        index = playerPrefsIntReader.Value;
    }
}
