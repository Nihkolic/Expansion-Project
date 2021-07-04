using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackCollisions : MonoBehaviour
{
	PlayerHealth health;
	private void Awake()
	{
		health = GameObject.FindWithTag("Player").GetComponent<PlayerHealth>();
	}
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "PlayerCollider")
		{
			health.Damage(2);
			
		}
	}

}
