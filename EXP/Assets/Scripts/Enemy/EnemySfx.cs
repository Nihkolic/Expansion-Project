using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySfx : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hurtClip;
    public AudioClip attackClip;
    public AudioClip detectedClip;
    bool played = false;

    public void PlayHurt()
    {
        audioSource.PlayOneShot(hurtClip, Random.Range(0.05f, 0.4f));
    }
    public void PlayAttack()
    {
        audioSource.PlayOneShot(attackClip, Random.Range(0f,0.1f));
    }
    public void PlayDetected()
    {
        if (!played)
        {
            audioSource.PlayOneShot(detectedClip, Random.Range(0.25f, 0.35f));
            played = true;
        }
    }
}
