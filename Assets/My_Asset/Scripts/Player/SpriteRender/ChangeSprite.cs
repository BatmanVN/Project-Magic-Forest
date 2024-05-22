using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSprite : MonoBehaviour
{
    [SerializeField] private Sprite[] spriteRenderers;
    [SerializeField] private SpriteRenderer characterSprite;
    [SerializeField] private string keyName;
    [SerializeField] private int index;
    [ContextMenu("Get")]
    public void ChooseSprite()
    {
        if(index >= 0 && index < spriteRenderers.Length)
        {
            characterSprite.sprite = spriteRenderers[index];
        }
        else
        {
            return;
        }
    }
    private int Get()
    {
        index = PlayerPrefs.GetInt(keyName, index);
        return index;
    }
    private void Update()
    {
        ChooseSprite();
    }
    private void Start()
    {
        Get();
    }
}
