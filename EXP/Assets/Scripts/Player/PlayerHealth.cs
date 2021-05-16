using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int hp;
    public int hpMax = 15;
    public Image hpBar;
    private void Start()
    {
        hp = hpMax;
    }
    public void Damage(int damageAmount)
    {
        hp -= damageAmount;
        if (hp < 0) hp = 0;
        UpdateUI();
    }
    public void Heal(int damageAmount)
    {
        hp += damageAmount;
        if (hp > hpMax) hp = hpMax;
        UpdateUI();
    }
    private void UpdateUI()
    {
        hpBar.fillAmount = GetHealthPercent();
    }
    public float GetHealthPercent()
    {
        return (float)hp / hpMax;
    }
}
