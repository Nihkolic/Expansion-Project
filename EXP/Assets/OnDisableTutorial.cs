using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDisableTutorial : MonoBehaviour
{
    public GameObject goBarrier;
    private void OnDisable()
    {
        Destroy(goBarrier);
    }
}
