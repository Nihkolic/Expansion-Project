using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollisions : MonoBehaviour
{
	/*
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Target")
		{
			
			FindObjectOfType<HitStop>().Stop(0.03f);

			//Toggle "isHit" on target object
			collision.transform.gameObject.GetComponent
				<TargetScript>().isHit = true;
			
			collision.transform.gameObject.GetComponent
				<EnemyHitStop>().isHit = true;
		}
	}*/
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "Target")
		{

			FindObjectOfType<HitStop>().Stop(0.03f);
			/*
			//Toggle "isHit" on target object
			col.transform.gameObject.GetComponent
				<TargetScript>().isHit = true;*/
			
			col.transform.gameObject.GetComponent
				<EnemyHitStop>().isHit = true;

		}
	}
}
