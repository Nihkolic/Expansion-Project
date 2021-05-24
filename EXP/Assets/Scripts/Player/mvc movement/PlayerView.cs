using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerView : MonoBehaviour
{
    public PlayerModel model;

    private void OnCollisionEnter(Collision col)
    {
        model.isGrounded = Physics.CheckSphere(model.goGroundCheck.position, model.groundDistance, model.groundMask);
        /*
        if(col.gameObject.tag == "Ground")
        {
            Instantiate(model.goFallEffect, model.goGroundCheck.transform.position, Quaternion.identity);
        }*/
    }
}
