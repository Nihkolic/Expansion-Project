using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float attackTimer = 1f; 
    float _attackTimer;  
    public Animator compAttack; 
    //public GameObject WeaponCollider;

    public string animAttack1;
    public string animAttack2;
    public string animIdle;
    //public Animator AnimFists;

    bool anim = false;
    void Start()
    {
        //WeaponCollider.SetActive(false);
        _attackTimer = attackTimer;
    }

    void Update()
    {
        if (!PauseControl.gameIsPaused)
        {
            RandomAttack();
        }
    }
    private void Attack(string attack)
    {
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                //WeaponCollider.SetActive(true);
                compAttack.Play(attack);
                //AnimFists.Play("fists-attack");
                attackTimer = _attackTimer;
                anim = !anim;
            }
        }
    }
    void RandomAttack()
    {
        if (anim == false)
        {
            Attack(animAttack1);
        }
        if(anim)
        {
            Attack(animAttack2);
        }
    }

    public void ResetAttack()
    {
        //WeaponCollider.SetActive(false);
        compAttack.Play(animIdle);

        //AnimFists.Play("fists-idle");
    }

}
