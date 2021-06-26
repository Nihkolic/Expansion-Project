using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerModel : MonoBehaviour
{
    public Transform orientation;

    [Header("Movement")]
    public float walkSpeed = 8f;
    [HideInInspector] public float movementMultiplier = 10f;
    public float airMultiplier = 0.4f;


    [Header("Jumping")]
    public float jumpForce = 5f;

    [Header("Keybinds")]
    public KeyCode jumpKey = KeyCode.Space;

    [Header("Drag")]
    [HideInInspector] public float groundDrag = 6f;
    [HideInInspector] public float airDrag = 2f;


    [HideInInspector] public float inputHorizontal;
    [HideInInspector] public float inputVertical;

    [Header("Ground Detection")]
    public LayerMask groundMask;
    public Transform goGroundCheck;
    [HideInInspector] public bool isGrounded;
    public float groundDistance = 0.4f;

    [HideInInspector] public Vector3 moveDirection;

    [HideInInspector] public Rigidbody rb;

    public GameObject goFallEffect;
    public PlayerSfx playerSfx;
    [HideInInspector] public bool hasFallen;
}

