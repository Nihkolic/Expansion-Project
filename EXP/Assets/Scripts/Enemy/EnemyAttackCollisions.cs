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
			//FindObjectOfType<HitStop>().Stop(0.05f);//0.03f
			//col.transform.gameObject.GetComponent<PlayerHealth>().Damage(1);
			health.Damage(1);
			
		}
	}

}
