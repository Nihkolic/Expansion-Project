using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerModel model;

    private void OnCollisionEnter(Collision collision)
    {
        model.isGrounded = Physics.CheckSphere(model.goGroundCheck.position, model.groundDistance, model.groundMask);
    }
}
