using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    //[SerializeField] GameObject goItemButton;
    public GameObject goEffectPickUp;

    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("PlayerCollider").GetComponent<Inventory>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PlayerCollider"))
        {
            inventory.num += 1;
            inventory.UpdateNum();
            Instantiate(goEffectPickUp, transform.position, Quaternion.identity);
            Destroy(gameObject);
            
        }
    }
}
