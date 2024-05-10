using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusDef : MonoBehaviour
{
    private const string defEffectParaname = "defEffect";
    [SerializeField] private Player_BonusDef player_bonusDef;
    [SerializeField] private HealthCharacter takeDame;
    [SerializeField] private GameObject defObj;
    [SerializeField] private Player_beAttack beAttack;
    [SerializeField] private Animator defEffect;
    [SerializeField] private float dameDef;
    [SerializeField] private float timeBonus;
    public bool enableEffect;
    public void BonusDEF()
    {
            defObj.SetActive(true);
            defEffect.SetTrigger(defEffectParaname);
            takeDame?.TakeDame(dameDef);
            enableEffect = true;
            StartCoroutine(TimeBonus());
    }
    private void DisableEffect()
    {
        enableEffect = false;
        player_bonusDef.enabled = false;
        defObj.SetActive(false);
    }
    private IEnumerator TimeBonus()
    {
        yield return new WaitForSeconds(timeBonus);
        DisableEffect();
    }
    private void Update()
    {
        
    }
}
