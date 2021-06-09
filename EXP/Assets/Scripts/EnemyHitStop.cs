using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitStop : MonoBehaviour
{
	
	[Header("Body")]
	Renderer rendBody;
	public Material matCurrentB;
	public Material matHurtB;

	[Header("Arm Right")]
	public Renderer rendArmRight;
	public Material matCurrentRight;
	public Material matHurtRight;

	[Header("Arm Left")]
	public Renderer rendArmLeft;
	public Material matCurrentLeft;
	public Material matHurtLeft;

	[HideInInspector] public bool isHit = false;
	private void Start()
	{
		rendBody = GetComponent<MeshRenderer>();
	}
	private void Update()
	{
		if (isHit == true)
		{
			rendBody.material = matHurtB;
			rendArmRight.material = matHurtRight;
			rendArmLeft.material = matHurtLeft;
			StartCoroutine(Back());
		}
	}
	IEnumerator Back()
	{
		while (Time.timeScale != 1.0f)
			yield return null;//wait for hit stop to end
		rendBody.material = matCurrentB;
		rendArmRight.material = matCurrentRight;
		rendArmLeft.material = matCurrentLeft;
	}
}
