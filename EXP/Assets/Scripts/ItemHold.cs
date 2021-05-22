using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHold : MonoBehaviour
{
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "Box")//change to the box
		{
			//Toggle "hold" on target object
			bool _hold = col.transform.gameObject.GetComponent<PickUpBox>().hold;
			if (Input.GetButton("Fire2"))
			{
				_hold = true;
				Debug.Log("aa");
			}
			else
			{
				_hold = false;
			}

		}
	}
}
