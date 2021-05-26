using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsPickUp : MonoBehaviour
{
    public float pickUpRange = 5f;
    public float moveForce = 250;
    public Transform holdParent;

    private GameObject goHeld;
    private void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            if (goHeld == null)
            {
                RaycastHit hit;
                if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange)) && hit.transform.tag == "Box")
                {
                    PickUpObject(hit.transform.gameObject);
                }
            }
            else
            {
                DropObject();
            }
        }
        if(goHeld != null)
        {
            MoveObject();
        }

    }
    void MoveObject()
    {
        if(Vector3.Distance(goHeld.transform.position, holdParent.position) > 0.1f)
        {
            Vector3 moveDirection = (holdParent.position - goHeld.transform.position);
            goHeld.GetComponent<Rigidbody>().AddForce(moveDirection * moveForce);
        }
    }
    void PickUpObject(GameObject goPick)
    {
        if (goPick.GetComponent<Rigidbody>())
        {
            Rigidbody rbPick = goPick.GetComponent<Rigidbody>();
            rbPick.useGravity = false;
            rbPick.drag = 10f;

            rbPick.transform.parent = holdParent;
            goHeld = goPick;
        }
    }
    void DropObject()
    {
        Rigidbody rbHeld = goHeld.GetComponent<Rigidbody>();
        rbHeld.useGravity = true;
        rbHeld.drag = 1f;

        rbHeld.transform.parent = null;
        goHeld = null;
    }
}
