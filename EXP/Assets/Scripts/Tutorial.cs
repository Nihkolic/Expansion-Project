using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    GameObject goTutorial;
    Text textTutorial;

    public int step;
    public GameObject goEnemy;

    [Header("HUD")]
    GameObject goItem;
    GameObject goWeapon;
    GameObject goLife;
    GameObject goOtherTutorial;
    GameObject tutorialGO;
    
    private void Awake()
    {
        goTutorial = GameObject.FindGameObjectWithTag("TutorialUI");
        goItem = GameObject.FindGameObjectWithTag("ItemUI");
        goWeapon = GameObject.FindGameObjectWithTag("WeaponUI");
        goLife = GameObject.FindGameObjectWithTag("LifeUI");
        goOtherTutorial = GameObject.FindGameObjectWithTag("OtherTutorialUI");
        tutorialGO = GameObject.FindGameObjectWithTag("TutorialGO");
    }
    private void Start()
    {
        textTutorial = goTutorial.GetComponent<Text>(); //textTutorial.text = "Use [W][A][S][D] to Move and [Space] to Jump";
        goItem.SetActive(false);
        goWeapon.SetActive(false);
        goLife.SetActive(false);
        goOtherTutorial.SetActive(false);
    }
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
                textTutorial.text = "Pick up a weapon";
                
                break;
            case 2:
                textTutorial.text = "Use the [LMB] to attack";
                goLife.SetActive(true);
                break;
            case 3:
                textTutorial.text = "Press [E] to heal yourself";
                goItem.SetActive(true);
                break;
            case 4:
                textTutorial.text = "Press [ESC] to pause the game and view the controls at any time";
                StartCoroutine("Fade");
                break;
            default:
                textTutorial.text = null;
                break;
        }
    
    }
    IEnumerator Fade()
    {
        yield return new WaitForSeconds(2f);
        goOtherTutorial.SetActive(true);
        tutorialGO.SetActive(false);
    }
}
