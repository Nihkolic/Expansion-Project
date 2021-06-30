using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSfx : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource2;
    public AudioClip healClip;
    public AudioClip heal2Clip;
    public AudioClip hurtClip;

    public AudioClip stepsClip;
    public AudioClip jumpClip;
    public AudioClip fallClip;
    //int randomSound=1;

    public void PlayHurt()
    {

        audioSource.PlayOneShot(hurtClip, Random.Range(0.1f, 0.4f));

    }
    public void PlayHeal()
    {
        audioSource.PlayOneShot(healClip, 0.15f);
        audioSource2.PlayOneShot(heal2Clip, Random.Range(0.4f, 0.55f));
    }
    public void PlaySteps()
    {
        //audioSource.PlayOneShot(stepsClip, Random.Range(0.05f,0.2f));
        audioSource.PlayOneShot(stepsClip, Random.Range(0.5f, 0.7f));

    }
    public void PlayJump()
    {
        //audioSource.PlayOneShot(jumpClip, 0.75f);
    }
    public void PlayFall()
    {
        audioSource.PlayOneShot(fallClip, Random.Range(0.02f, 0.1f));
    }
}
