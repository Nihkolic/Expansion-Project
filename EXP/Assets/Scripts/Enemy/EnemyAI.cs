using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    Transform target;
    [HideInInspector] public NavMeshAgent agent;
    //Animator anim;
    bool isDead = false;
    public bool puedeAtacar = true; 
    [SerializeField] float chaseDistance = 10f; //2
    [SerializeField] float turnSpeed = 10f; //5
    public int DamageAmount = 3;
    [SerializeField] float ataqueTime = 2f;

    PlayerHealth playerHealth;
    GameObject player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PlayerCollider");
        target = player.transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();
    }
    void Update()
    {
        float distance = Vector3.Distance(transform.position, target.position);

        if (!isDead/* && !PlayerHealth.isDead*/)
        {
            if (distance > chaseDistance && puedeAtacar)
            {
                //AtaquePlayer();
            }
            else if (distance > chaseDistance)
            {
                ChasePlayer();
            }
        }
       
        else
        {
            DesactivarEnemy();
        }
    }

    void ChasePlayer()
    {
        agent.updatePosition = true;
        //agent.updatePosition = true;
        agent.SetDestination(target.position);
        //anim.SetBool("aquíVaLaAnimaciondecaminar",true);
        //anim.SetBool("aquíVaLaAnimacionDeAtaque",false);

    }

    void AtaquePlayer()
    {
        agent.updateRotation = false;
        Vector3 direction = target.position - transform.position;
        direction.y = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction),turnSpeed * Time.deltaTime);
        agent.updatePosition = false;
        //anim.SetBool("aquíVaLaAnimaciondecaminar",false);
        //anim.SetBool("aquíVaLaAnimacionDeAtaque",true);
        
        StartCoroutine(AtaqueTiempo());

    }
    void DesactivarEnemy()
    {
        puedeAtacar = false;
        //anim.SetBool("aquíVaLaAnimaciondecaminar",false);
        //anim.SetBool("aquíVaLaAnimacionDeAtaque",false);
    }

    IEnumerator AtaqueTiempo()
    {
        puedeAtacar = false;
        yield return new WaitForSeconds(0.5f);
        //playerHealth.Damage(DamageAmount); aaaaaaaaaaaaaaaaaaaaahhhhhhhhh
        yield return new WaitForSeconds(ataqueTime);
        puedeAtacar = true;
    }/*

    public void EnemyDeathAnim()
    {
         isDead = true;
         anim.SetTrigger("isDead");
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) ;
        {
            playerInRange = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) ;
        {
            playerInRange = false;
        }
    }*/
}
