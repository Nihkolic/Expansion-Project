using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int hp;
    public int hpMax = 20;
    public Image hpBar;
 
    public Animator screenEffect;
    public Text textHP;

    public float timeBetweenAttack = 0.9f;
    float _timeBetweenAttack;

    public PlayerSfx playerSfx;

    private void Update()
    {
        timeBetweenAttack -= Time.deltaTime;
    }
    private void Start()
    {
        hpMax *= 10;
        hp = hpMax;
        //textHP.text = ("  " + hp.ToString() + " / " + hpMax.ToString());
        textHP.text = ("  " + hp.ToString());
        _timeBetweenAttack = timeBetweenAttack;
    }
    public void Damage(int amount)
    {
        if (timeBetweenAttack < 0)
        {
            hp -= amount * 10;
            CheckHP();
            screenEffect.Play("HurtScreen");
            UpdateUI();
            timeBetweenAttack = _timeBetweenAttack;
            playerSfx.PlayHurt();
        }
    }
    public void Heal(int amount)
    {
        hp += amount*10;
        if (hp > hpMax) hp = hpMax;
        screenEffect.Play("HealScreen");
        UpdateUI();
        playerSfx.PlayHeal();
    }
    private void UpdateUI()
    {
        hpBar.fillAmount = GetHealthPercent();
        //textHP.text = ("  " + hp.ToString() + " / " + hpMax.ToString());
        textHP.text = ("  " + hp.ToString());
    }
    private void CheckHP()
    {
        if (hp<=0)
        {
            SceneManager.LoadScene(2);
        }
    }
    public float GetHealthPercent()
    {
        return (float)hp / hpMax;
    }
}
