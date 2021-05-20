using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerModel model;
    public PlayerController controller;
    private void FixedUpdate()
    {
        controller.Movement();
        model.isGrounded = Physics.CheckSphere(model.goGroundCheck.position, model.groundDistance, model.groundMask);
        //try using oncollisionenter
    }
}
