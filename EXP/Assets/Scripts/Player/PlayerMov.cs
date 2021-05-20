using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    [SerializeField] Transform orientation;

    [Header("Movement")]
    [SerializeField] float walkSpeed;
    float movementMultiplier = 10;
    [SerializeField] float airMultiplier = 0.4f;


    [Header("Jumping")]
    public float jumpForce = 5f;

    [Header("Keybinds")]
    [SerializeField] KeyCode jumpKey = KeyCode.Space;

    [Header("Drag")]
    float groundDrag = 6f;
    float airDrag = 2f;


    float inputHorizontal;
    float inputVertical;

    [Header("Ground Detection")]
    [SerializeField] LayerMask groundMask;
    public Transform goGroundCheck;
    bool isGrounded;
    [SerializeField] float groundDistance = 0.4f;
    
    Vector3 moveDirection;

    Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        Inputs();
        ControlDrag();
        if (isGrounded && Input.GetKeyDown(jumpKey))
            Jump();
    }
    private void FixedUpdate()
    {
        Movement();
        isGrounded = Physics.CheckSphere(goGroundCheck.position, groundDistance, groundMask);
        //try using oncollisionenter
    }
    void Inputs()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        moveDirection = orientation.forward * inputVertical + orientation.right * inputHorizontal;
    }
    void Movement()
    {
        if(isGrounded)
            rb.AddForce(moveDirection.normalized * walkSpeed * movementMultiplier, ForceMode.Acceleration);
        else if (!isGrounded)
            rb.AddForce(moveDirection.normalized * walkSpeed * movementMultiplier*airMultiplier, ForceMode.Acceleration);
            //fall faster here
    }
    void ControlDrag()//try to tweak this a lil bit
    {
        if (isGrounded)
        {
            rb.drag = groundDrag;
        }
        else
        {
            rb.drag = airDrag;
        }
    }
    void Jump()
    {
        if (isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, 0, rb.velocity.z);
            rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        }   
    }
}
