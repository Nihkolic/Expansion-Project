using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
	public int levelIndex = 3;
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "PlayerCollider")
		{
			SceneManager.LoadScene(levelIndex);

		}
	}
}
