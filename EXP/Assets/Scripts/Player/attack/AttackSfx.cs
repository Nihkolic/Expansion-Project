using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackSfx : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip attackClip1;
    public AudioClip attackClip2;

    public void PlayAttack(int num)
    {
        if (num == 1)
        {
            audioSource.PlayOneShot(attackClip1, 0.25f);
        }
        if (num == 2)
        {
            audioSource.PlayOneShot(attackClip2, 0.25f);
        }
    }
}
