using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject goItemButton;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<Inventory>();
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollider"))
        {
            for (int i = 0; i < inventory.goSlots.Length; i++)
            {
                if (inventory.isFull[i] == false)
                {
                    //item can be added to the inventory
                    inventory.isFull[i] = true;
                    Instantiate(goItemButton, inventory.goSlots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}
