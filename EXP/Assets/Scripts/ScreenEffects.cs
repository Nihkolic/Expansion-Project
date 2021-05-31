using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEffects : MonoBehaviour
{
    public Animator animScreen;
    //public PostProcessingEffects postProcessing;
    public string idleAnim;
    public void BackToIdle()
    {
        animScreen.Play(idleAnim);
    }
    public void ResetVolume()
    {
        //postProcessing.ResetVignette();
    }
}
