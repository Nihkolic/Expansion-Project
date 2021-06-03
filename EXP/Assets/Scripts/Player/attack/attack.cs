using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float attackTimer = 1f; //However long you want the delay between attacks to be
    float _attackTimer;  
    public Animator compAttack; //Drag the attack animation here
    //public GameObject WeaponCollider;

    public string animAttack;
    public string animIdle;
    //public Animator AnimFists;

    void Start()
    {
        //WeaponCollider.SetActive(false);
        _attackTimer = attackTimer;
    }

    void Update()
    {
        if (!PauseControl.gameIsPaused)
        {
            Attack();
        }
    }
    private void Attack()
    {
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                //WeaponCollider.SetActive(true);
                compAttack.Play(animAttack);
                //AnimFists.Play("fists-attack");
                attackTimer = _attackTimer;
            }
        }
    }

    public void ResetAttack()
    {
        //WeaponCollider.SetActive(false);
        compAttack.Play(animIdle);

        //AnimFists.Play("fists-idle");
    }

}
