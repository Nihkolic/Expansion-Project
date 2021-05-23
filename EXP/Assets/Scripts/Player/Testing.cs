using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] PlayerHealth playerHealth;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            playerHealth.Damage(1);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            playerHealth.Heal(1);
        }
        if (Input.GetMouseButton(1))
        {
            Debug.Log("Right");
        }
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Left");
        }
    }
}
