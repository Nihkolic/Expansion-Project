using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemHold : MonoBehaviour
{
	private void OnCollisionEnter(Collision col)
	{
		if (col.transform.tag == "Box")
		{
			if (Input.GetMouseButton(1))
			{
				col.transform.gameObject.GetComponent<PickUpBox>().hold = true;
				Debug.Log("aa");
			}
			else
			{
				col.transform.gameObject.GetComponent<PickUpBox>().hold = false;
			}
			Debug.Log("box");
		}
	}
}
