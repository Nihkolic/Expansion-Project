using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerModel model;
    private void Start()
    {
        model.rb.freezeRotation = true;
    }
    void Update()
    {
        Inputs();
        ControlDrag();
        if (model.isGrounded && Input.GetKeyDown(model.jumpKey))
            Jump();
    }/*
    private void FixedUpdate()
    {
        Movement();
        model.isGrounded = Physics.CheckSphere(model.goGroundCheck.position, model.groundDistance, model.groundMask);
        //try using oncollisionenter
    }*/
    void Inputs()
    {
        model.inputHorizontal = Input.GetAxisRaw("Horizontal");
        model.inputVertical = Input.GetAxisRaw("Vertical");

        model.moveDirection = model.orientation.forward * model.inputVertical + model.orientation.right * model.inputHorizontal;
    }
    public void Movement()
    {
        if (model.isGrounded)
            model.rb.AddForce(model.moveDirection.normalized * model.walkSpeed * model.movementMultiplier, ForceMode.Acceleration);
        else if (!model.isGrounded)
            model.rb.AddForce(model.moveDirection.normalized * model.walkSpeed * model.movementMultiplier * model.airMultiplier, ForceMode.Acceleration);
        //fall faster here
    }
    void ControlDrag()//try to tweak this a lil bit
    {
        if (model.isGrounded)
        {
            model.rb.drag = model.groundDrag;
        }
        else
        {
            model.rb.drag = model.airDrag;
        }
    }
    void Jump()
    {
        if (model.isGrounded)
        {
            model.rb.velocity = new Vector3(model.rb.velocity.x, 0, model.rb.velocity.z);
            model.rb.AddForce(transform.up * model.jumpForce, ForceMode.Impulse);
        }
    }
}
