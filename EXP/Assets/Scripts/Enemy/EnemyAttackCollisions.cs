using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackCollisions : MonoBehaviour
{
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "Player")
		{
			//FindObjectOfType<HitStop>().Stop(0.05f);//0.03f
			col.transform.gameObject.GetComponent
				<PlayerHealth>().Damage(1);
			Debug.Log("aaaaaa");
		}
	}
}
