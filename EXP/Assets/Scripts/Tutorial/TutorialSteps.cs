using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialSteps : MonoBehaviour
{
    public TutorialVar var;
    public int step;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCollider"))
        {
            var.Step(step);
            Destroy(gameObject, 1f);
        }
    }
}
