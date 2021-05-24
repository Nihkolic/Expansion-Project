using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int hp;
    public int hpMax = 15;
    public Image hpBar;
    //public GameObject goBloodScreen;
    public Animator animBloodScreen;
    private void Start()
    {
        hp = hpMax;
        //animBloodScreen = goBloodScreen.GetComponent<Animator>();
    }
    public void Damage(int amount)
    {
        hp -= amount;
        if (hp < 0) hp = 0;
        animBloodScreen.Play("Hurt");
        UpdateUI();
    }
    public void Heal(int amount)
    {
        hp += amount;
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
    public void ResetHurtAnim()
    {
        animBloodScreen.Play("Idle");
    }
}
