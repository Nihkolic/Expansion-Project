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
            Step(step);
        }
    }
    void Step(int step)
    {
        switch (step)
        {
            case 1:
                var.textTutorial.text = "Pick up a weapon";
                
                break;
            case 2:
                var.textTutorial.text = "Use the [LMB] to attack";
                var.goLife.SetActive(true);
                break;
            case 3:
                var.textTutorial.text = "Press [E] to heal yourself";
                var.goItem.SetActive(true);
                break;
            case 4:
                var.textTutorial.text = "Press [ESC] to pause the game and view the controls at any time";
                StartCoroutine(TutorialToObjective());
                break;
            default:
                var.textTutorial.text = null;
                break;
        }
    
    }
    IEnumerator TutorialToObjective()
    {
        yield return new WaitForSeconds(2f);
        var.goObjective.SetActive(true);
        var.goTutorialParent.SetActive(false);
    }
}
