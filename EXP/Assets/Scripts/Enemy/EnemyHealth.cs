using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public float enemyHealth = 100f;
    EnemyNewAI enemyAI;
    public bool isEnemyDead;
    public Collider[] enemyCol;
    public EnemySfx enemySfx;
    public GameObject goEnemyDeath;
    public Transform enemyDeath;
    private void Start()
    {
        enemyAI = GetComponent<EnemyNewAI>();
    }
    public void DeductHealth(float deductHealth)
    {
        if (!isEnemyDead)
        {
            enemyHealth -= deductHealth;
            enemySfx.PlayHurt();
        }

        if(enemyHealth <= 0) 
        { 
            EnemyDead();
            
        }
    }
    void EnemyDead()
    {
        if (isEnemyDead == false)
        {
            Instantiate(goEnemyDeath, enemyDeath.position, Quaternion.identity);
            isEnemyDead = true;
        }
        Destroy(gameObject);
        //enemyAI.EnemyDeathAnim();
        //enemyAI.agent.speed = 0f;
        /*
        foreach (var col in enemyCol)
        {
            col.enabled = false;
        }*/

        //Destroy(gameObject,0.5f);
    }
}
