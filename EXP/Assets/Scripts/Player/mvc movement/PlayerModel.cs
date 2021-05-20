using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    public Transform orientation;

    [Header("Movement")]
    public float walkSpeed = 8f;
    public float movementMultiplier = 10f;
    public float airMultiplier = 0.4f;


    [Header("Jumping")]
    public float jumpForce = 5f;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Drag")]
    public float groundDrag = 6f;
    public float airDrag = 2f;


    public float inputHorizontal;
    public float inputVertical;

    [Header("Ground Detection")]
    public LayerMask groundMask;
    public Transform goGroundCheck;
    public bool isGrounded;
    public float groundDistance = 0.4f;

    public Vector3 moveDirection;

    public Rigidbody rb;
    void Awake()
    {
        rb = GetComponent<Rigidbody>();
       
    }
}
