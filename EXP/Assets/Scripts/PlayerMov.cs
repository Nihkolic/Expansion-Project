using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    float playerHeight = 2f;

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
    float groundDistance = 0.4f;
    
    Vector3 moveDirection;

    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(goGroundCheck.position, groundDistance, groundMask);
        
        print(isGrounded);
        Inputs();
        ControlDrag();
    }
    private void FixedUpdate()
    {
        Movement();
        
    }
    void Inputs()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");

        if (isGrounded && Input.GetKeyDown(jumpKey))
            Jump();

        moveDirection = transform.forward * inputVertical + transform.right * inputHorizontal;
    }
    void Movement()
    {
        if(isGrounded)
            rb.AddForce(moveDirection.normalized * walkSpeed * movementMultiplier, ForceMode.Acceleration);
        else if (!isGrounded)
            rb.AddForce(moveDirection.normalized * walkSpeed * movementMultiplier*airMultiplier, ForceMode.Acceleration);
    }
    void ControlDrag()
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
        
        Debug.Log("jump");
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
        
    }
}
