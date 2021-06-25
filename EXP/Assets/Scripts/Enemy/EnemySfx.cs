using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySfx : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hurtClip;
    public AudioClip attackClip;
    public AudioClip detectedClip; //or ambient

    public void PlayHurt()
    {
        audioSource.PlayOneShot(hurtClip, 0.65f);
    }
    public void PlayAttack()
    {
        //audioSource.PlayOneShot(attackClip, 0.35f);
    }
    public void PlayDetected()
    {
        audioSource.PlayOneShot(detectedClip, 0.05f);
    }
}
