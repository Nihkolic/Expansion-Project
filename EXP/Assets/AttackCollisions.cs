using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCollisions : MonoBehaviour
{
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "Target")
		{
			//Toggle "isHit" on target object
			collision.transform.gameObject.GetComponent
				<TargetScript>().isHit = true;
			Debug.Log("2");
		}
		Debug.Log("1");
	}
}
