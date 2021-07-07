using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class EnemyPatrol : MonoBehaviour
{
	[HideInInspector]
	public NavMeshAgent agent;
	Transform player;

	[Header("Layers")]
	public LayerMask whatIsGround;
	public LayerMask whatIsPlayer;

	[Header("Patrolling")]
	public float patrollingMovSpeed = 8f;
	public float chasingMovSpeed = 13f;
	public float walkPointRange;
	Vector3 walkPoint;
	bool walkPointSet;
	public float sightRange;

	[Header("Attack")]
	public float attackMovSpeed = 2f;
	public float timeBetweenAttack;
	float _timeBetweenAttack;
	//bool alreadyAttacked;
	public float attackRange;
	Animator anim;

	bool playerInSightRange, playerInAttackRange;
	public EnemySfx enemySfx;
	public enum State
	{
		patrolling,
		chasing,
		attack
	}
	public State state = State.patrolling;

	private void Awake()
	{
		if (1 == SceneManager.GetActiveScene().buildIndex)
		{
			player = GameObject.Find("New Player").transform;

		}

		agent = GetComponent<NavMeshAgent>();
		anim = GetComponent<Animator>();
		_timeBetweenAttack = timeBetweenAttack;
	}

	private void Update()
	{
		Patroling();
	}
	private void LateUpdate()
	{
		transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y, 0);
	}

	private void Patroling()
	{
		agent.speed = patrollingMovSpeed;
		if (!walkPointSet) 
		{ 
			SearchWalkPoint(); 
		}
		if (walkPointSet)
		{
			agent.SetDestination(walkPoint);
		}

		Vector3 distanceToWalkPoint = transform.position - walkPoint;

		//Walkpoint reached
		if (distanceToWalkPoint.magnitude < 1f)
			walkPointSet = false;
	}
	private void SearchWalkPoint()
	{
		//Calculate random point in range
		float randomZ = Random.Range(-walkPointRange, walkPointRange);
		float randomX = Random.Range(-walkPointRange, walkPointRange);

		walkPoint = new Vector3(transform.position.x + randomX, transform.position.y, transform.position.z + randomZ);

		if (Physics.Raycast(walkPoint, -transform.up, 2f, whatIsGround))
			walkPointSet = true;
	}
	/*
	private void ChasePlayer()
	{
		agent.SetDestination(player.position);
		enemySfx.PlayDetected();
	}
	private void AttackPlayer()
	{
		//Make sure enemy doesn't move
		agent.SetDestination(transform.position);
		transform.LookAt(player);
		timeBetweenAttack -= Time.deltaTime;
		if (timeBetweenAttack<0)
		{
			Attack();
			agent.speed = attackMovSpeed;
			timeBetweenAttack = _timeBetweenAttack;
			//Invoke(nameof(ResetAttack), timeBetweenAttacks);
		}
	}
	private void Attack()
	{
		anim.Play("EnemyAttack");
		enemySfx.PlayAttack();
	}
	public void ResetAttack()
	{
		anim.Play("EnemyIdle");
	}*/
	private void OnDrawGizmosSelected()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireSphere(transform.position, sightRange);
		Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, attackRange);
	}
}
