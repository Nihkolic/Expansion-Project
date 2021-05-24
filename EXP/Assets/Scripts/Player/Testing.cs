using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Testing : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            playerHealth.Damage(1);
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            playerHealth.Heal(1);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
           
        }

    }
}
