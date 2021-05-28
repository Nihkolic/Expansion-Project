using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int hp;
    public int hpMax = 20;
    public Image hpBar;
 
    public Animator screenEffect;
    public Text textHP;
    
    private void Start()
    {
        hpMax *= 10;
        hp = hpMax;
        textHP.text = ("  " + hp.ToString() + " / " + hpMax.ToString());
    }
    public void Damage(int amount)
    {
        hp -= amount*10;
        if (hp < 0) hp = 0;
        screenEffect.Play("HurtScreen");
        UpdateUI();
    }
    public void Heal(int amount)
    {
        hp += amount*10;
        if (hp > hpMax) hp = hpMax;
        screenEffect.Play("HealScreen");
        UpdateUI();
    }
    private void UpdateUI()
    {
        hpBar.fillAmount = GetHealthPercent();
        textHP.text = ("  " + hp.ToString() + " / " + hpMax.ToString());
    }
    public float GetHealthPercent()
    {
        return (float)hp / hpMax;
    }
}
