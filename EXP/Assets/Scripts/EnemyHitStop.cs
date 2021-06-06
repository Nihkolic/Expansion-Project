using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitStop : MonoBehaviour
{
	public bool isHit = false;

	Renderer rend;
	public Material currentMat;
	public Material M2;

	private void Start()
	{
		rend = GetComponent<MeshRenderer>();
	}
	private void Update()
	{
		if (isHit == true)
		{
			rend.material = M2;
			StartCoroutine(Back());
		}
	}
	IEnumerator Back()
	{
		while (Time.timeScale != 1.0f)
			yield return null;//wait for hit stop to end
		rend.material = currentMat;
	}
}
