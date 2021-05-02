using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimEvents : MonoBehaviour
{
    public Animator compAttack;
    public GameObject SwordCollider;
    //public Animator AnimFists;
    public void ResetAttack()
    {
        SwordCollider.SetActive(false);
        compAttack.Play("fist-idle");
        //AnimFists.Play("fists-idle");
    }
}
