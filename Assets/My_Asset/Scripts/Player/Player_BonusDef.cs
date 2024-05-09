using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_BonusDef : MonoBehaviour
{
    private const string defEffectParaname = "defEffect";
    [SerializeField] private Player_BonusDef player_bonusDef;
    [SerializeField] private BonusDef bonusDef;
    [SerializeField] private GameObject defObj;
    [SerializeField] private Attack_Player attack_Player;
    [SerializeField] private Animator defEffect;
    [SerializeField] private float timeBonus;
    private void BonusDEF()
    {
        if(bonusDef.eatDef == true)
        {
            defObj.SetActive(true);
            defEffect.SetTrigger(defEffectParaname);
            StartCoroutine(TimeBonus());
        }
    }
    private void DisableEffect()
    {
        player_bonusDef.enabled = false;
        defObj.SetActive(false);
        bonusDef.eatDef = false;
    }
    private IEnumerator TimeBonus()
    {
        yield return new WaitForSeconds(timeBonus);
        DisableEffect();
    }
    private void Update()
    {
        BonusDEF();
    }
}
