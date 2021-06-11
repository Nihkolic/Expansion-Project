using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{
	
	private void OnTriggerEnter(Collider col)
	{
		if (col.transform.tag == "PlayerCollider")
		{
			SceneManager.LoadScene(3);

		}
	}
}
