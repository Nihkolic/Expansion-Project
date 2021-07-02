using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject goTutorial;
    Text textTutorial;
    //bool activated = false;
    public int step;
    [Header("HUD")]
    [SerializeField] GameObject goItem;
    [SerializeField] GameObject goWeapon;
    [SerializeField] GameObject goLife;
    
    private void Start()
    {
        textTutorial = goTutorial.GetComponent<Text>();
        if (1 == SceneManager.GetActiveScene().buildIndex) //1 for testing, change this later
        {
            goTutorial.SetActive(true);
            
        }
        else
        {
            goTutorial.SetActive(false);
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerCollider"))
        {
            Step(step, other.gameObject);
        }
    }
    void Step(int step, GameObject go)
    {
        switch (step)
        {
            case 1:
                textTutorial.text = "Use [W][A][S][D] to move and [Space] to Jump";
                break;
            case 2:
                textTutorial.text = "Use the [RMB] to Attack";
                break;
            case 3:
                textTutorial.text = "Press [E] to Heal yourself";
                break;
            case 4:
                textTutorial.text = "Press [ESC] to pause the game and view the controls at any time";
                break;
            default:
                textTutorial.text = null;
                break;
        }
    }
}
