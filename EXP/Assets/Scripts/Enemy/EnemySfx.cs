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
        audioSource.PlayOneShot(hurtClip, Random.Range(0.35f, 0.6f));
    }
    public void PlayAttack()
    {
        if(audioSource.isPlaying)
            audioSource.PlayOneShot(attackClip, Random.Range(0.1f,0.2f));
    }
    public void PlayDetected()
    {
        audioSource.PlayOneShot(detectedClip, 0.05f);
    }
}
