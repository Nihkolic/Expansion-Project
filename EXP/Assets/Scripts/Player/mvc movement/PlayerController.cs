using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerModel model;
    private void Start()
    {
        model.rb = GetComponent<Rigidbody>();
        model.rb.freezeRotation = true;
    }
    void Update()
    {
        Inputs();
        ControlDrag();
        Land();
        Steps();
        if (model.isGrounded && Input.GetKeyDown(model.jumpKey))
            Jump();
    }
    private void FixedUpdate()
    {
        Movement();
    }

    void Inputs()
    {
        model.inputHorizontal = Input.GetAxisRaw("Horizontal");
        model.inputVertical = Input.GetAxisRaw("Vertical");

        model.moveDirection = model.orientation.forward * model.inputVertical + model.orientation.right * model.inputHorizontal;
    }
    void Movement()
    {
        if (model.isGrounded)
        {
            model.rb.AddForce(model.moveDirection.normalized * model.walkSpeed * model.movementMultiplier, ForceMode.Acceleration);
            
        }
        else if (!model.isGrounded)
        {
            model.rb.AddForce(model.moveDirection.normalized * model.walkSpeed * model.movementMultiplier * model.airMultiplier, ForceMode.Acceleration);
            StartCoroutine(Drop());
        }
    }
    IEnumerator Drop()
    {
        yield return new WaitForSeconds(.35f);
        model.rb.AddForce(transform.up * -0.95f, ForceMode.Impulse);
        
    }
    void ControlDrag()
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
            model.playerSfx.PlayJump();
        }
    }
    void Land()
    {
        if (model.isGrounded)
        {
            if (model.hasFallen)
            {
                model.playerSfx.PlayFall();
                model.hasFallen = false;
            }
        }
        if (!model.isGrounded)
        {
            model.hasFallen = true;
        }
    }
    void Steps()
    {
        if (model.isGrounded && !model.playerSfx.audioSource.isPlaying)
        {
            if ((model.inputHorizontal != 0) || (model.inputVertical != 0))
                model.playerSfx.PlaySteps();
        }
    }
}
