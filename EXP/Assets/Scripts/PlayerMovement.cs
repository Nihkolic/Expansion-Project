using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float walkSpeed = 6.0f;
    [SerializeField] float gravity = -13.0f;
    [SerializeField] [Range(0.0f, 0.5f)] float moveSmoothTime = 0.3f;

    float velocityY = 0.0f;
    private float _jumpHeight = 3f;
    CharacterController compController = null;

    Vector2 currentDir = Vector2.zero;
    Vector2 currentDirVelocity = Vector2.zero;
    void Start()
    {
        compController = GetComponent<CharacterController>();
    }
    void Update()
    {
        UpdateMovement();
    }
    void UpdateMovement()
    {
        Vector2 targetDir = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        targetDir.Normalize();

        currentDir = Vector2.SmoothDamp(currentDir, targetDir, ref currentDirVelocity, moveSmoothTime);
        /*
        if (compController.isGrounded)
            velocityY = 0.0f;

        if (Input.GetButtonDown("Jump") && compController.isGrounded)
            velocityY = Mathf.Sqrt(_jumpHeight * -2f * gravity);
        
        velocityY += gravity * Time.deltaTime;
        */
        Vector3 velocity = (transform.forward * currentDir.y + transform.right * currentDir.x) * walkSpeed + Vector3.up * velocityY;

        //compController.Move(velocity * Time.deltaTime);
    }
}
