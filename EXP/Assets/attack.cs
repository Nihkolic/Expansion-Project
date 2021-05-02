using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack : MonoBehaviour
{
    public float attackTimer = 1f; //However long you want the delay between attacks to be
    float _attackTimer;  
    public Animator compAttack; //Drag the attack animation here
    public GameObject SwordCollider;
    //public Animator AnimFists;

    void Start()
    {
        SwordCollider.SetActive(false);
        _attackTimer = attackTimer;
    }

    void Update()
    {
        attackTimer -= Time.deltaTime;
        if (attackTimer < 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                SwordCollider.SetActive(true);
                compAttack.Play("fist-attack");
                //AnimFists.Play("fists-attack");
                attackTimer = _attackTimer;
            }
        }
    }
    public void ResetAttack()
    {
        SwordCollider.SetActive(false);
        compAttack.Play("fist-idle");
        //AnimFists.Play("fists-idle");
    }

}
