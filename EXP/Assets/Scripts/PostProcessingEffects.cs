using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class PostProcessingEffects : MonoBehaviour
{
    public Volume volume;
    private Vignette _vignette;

    private void Start()
    {
        volume.profile.TryGet(out _vignette);
        _vignette.color.value = Color.black;
    }
    public void ResetVignette()
    {
        _vignette.color.value = Color.black;
    }
}
