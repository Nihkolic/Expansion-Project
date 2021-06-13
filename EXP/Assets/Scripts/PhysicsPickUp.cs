using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysicsPickUp : MonoBehaviour
{
    public float pickUpRange = 5f;
    public float moveForce = 250;
    public Transform holdParent;

    private GameObject goHeld;
    public GameObject goText;
    Text tutorialText;
    bool isBoxHeld = false;
    bool isLooking = false;
    private void Awake()
    {
        tutorialText = goText.GetComponent<Text>();
    }
    private void Update()
    {
        TutorialTest();
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
            rbPick.angularDrag = 10f;

            rbPick.transform.parent = holdParent;
            goHeld = goPick;

            isBoxHeld = true;
        }
    }
    void DropObject()
    {
        Rigidbody rbHeld = goHeld.GetComponent<Rigidbody>();
        rbHeld.useGravity = true;
        rbHeld.drag = 1f;
        rbHeld.angularDrag = 1f;

        rbHeld.transform.parent = null;
        goHeld = null;

        isBoxHeld = false;
    }
    void TutorialTest()
    {
        RaycastHit hit;
        if ((Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange)) && hit.transform.tag == "Box")
        {
            isLooking = true;
        }
        else
        {
            isLooking = false;
        }

        if (isBoxHeld)
        {
            tutorialText.text = "Press [RMB] to drop a box";
        }else if (!isBoxHeld)
        {
            tutorialText.text = "Press [RMB] to pick up a box";
        }

        if (isLooking)
        {
            goText.SetActive(true);
        }
        else if (!isLooking && !isBoxHeld)
        {
            goText.SetActive(false);
        }
    }
}
