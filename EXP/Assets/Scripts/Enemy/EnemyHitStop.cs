using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitStop : MonoBehaviour
{
	
	[Header("Body")]
	Renderer rendBody;
	public Material matCurrentB1;
	public Material matHurtB1;

	public Material matCurrentB2;
	public Material matHurtB2;

	public Material matCurrentB3;
	public Material matHurtB3;

	//Mat change
	int matIndex;
	Material matCurrent;
	Material matHurt;

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
		ChooseMat();
	}
	void ChooseMat()
	{
		matIndex = Random.Range(1, 4);
		switch (matIndex)
		{
			case 1:
				matCurrent = matCurrentB1;
				matHurt = matHurtB1;
				break;
			case 2:
				matCurrent = matCurrentB2;
				matHurt = matHurtB2;
				break;
			case 3:
				matCurrent = matCurrentB3;
				matHurt = matHurtB3;
				break;
		}
		rendBody.material = matCurrent;
	}
	private void Update()
	{
		if (isHit == true)
		{
			rendBody.material = matHurt;
			rendArmRight.material = matHurtRight;
			rendArmLeft.material = matHurtLeft;
			StartCoroutine(Back());
		}
	}
	IEnumerator Back()
	{
		while (Time.timeScale != 1.0f)
			yield return null;//wait for hit stop to end
		rendBody.material = matCurrent;
		rendArmRight.material = matCurrentRight;
		rendArmLeft.material = matCurrentLeft;
	}
}
