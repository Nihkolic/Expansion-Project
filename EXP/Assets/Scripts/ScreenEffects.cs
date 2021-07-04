using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEffects : MonoBehaviour
{
    public Animator animScreen;
    public string idleAnim;
    public void BackToIdle() 
    {
        animScreen.Play(idleAnim);
    }
}
