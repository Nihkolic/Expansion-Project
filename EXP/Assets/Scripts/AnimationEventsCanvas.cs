using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventsCanvas : MonoBehaviour
{
    public Animator animBloodScreen;
    public void ResetHurtAnim()
    {
        animBloodScreen.Play("Idle");
    }
}
