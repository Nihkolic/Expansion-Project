using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEffects : MonoBehaviour
{
    public Animator animBloodScreen;
    public PostProcessingEffects postProcessing;
    public string idleAnim;
    public void ResetHurtAnim()
    {
        animBloodScreen.Play(idleAnim);
    }
    public void ResetVolume()
    {
        postProcessing.ResetVignette();
    }
}
