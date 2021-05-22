using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpBox : MonoBehaviour
{
    public Transform goItemHold;
    Rigidbody rb;
    BoxCollider bv;
    public bool hold=false;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        bv = GetComponent<BoxCollider>();
    }
    private void Update()
    {
        if (hold)
        {
            OnPickUp();
        }
        else
        {
            OnDrop();
        }
    }

    public void OnPickUp()
    {
        bv.enabled = false;
        rb.useGravity = false;
        transform.position = goItemHold.position;
        transform.parent = GameObject.Find("ItemHold").transform;
    }
    public void OnDrop()
    {
        bv.enabled = true;
        rb.useGravity = true;
        transform.parent = null;
    }

}
