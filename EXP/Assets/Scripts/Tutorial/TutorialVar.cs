using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialVar : MonoBehaviour 
{
    [HideInInspector] public GameObject goTutorialParent;
    [HideInInspector] public GameObject goTutorial;
    [HideInInspector] public Text textTutorial;

    [HideInInspector] public GameObject goItem;
    [HideInInspector] public GameObject goWeapon;
    [HideInInspector] public GameObject goLife;
    [HideInInspector] public GameObject goObjective;

    public AudioSource audioSource;
    public AudioClip tutorialClip;
    private void Awake()
    {
        goTutorialParent = GameObject.FindGameObjectWithTag("TutorialUI");
        goTutorial = goTutorialParent.transform.GetChild(0).gameObject;
        goItem = GameObject.FindGameObjectWithTag("ItemUI");
        goWeapon = GameObject.FindGameObjectWithTag("WeaponUI");
        goLife = GameObject.FindGameObjectWithTag("LifeUI");
        goObjective = GameObject.FindGameObjectWithTag("ObjectiveUI");
    }
    private void Start()
    {
        textTutorial = goTutorial.GetComponent<Text>(); //textTutorial.text = "Use [W][A][S][D] to Move and [Space] to Jump";
        goItem.SetActive(false);
        goWeapon.SetActive(false);
        goLife.SetActive(false);
        goObjective.SetActive(false);
    }
    public void Step(int step)
    {
        switch (step)
        {
            case 1:
                textTutorial.text = "Pick up the sword";
                PlayTutorial();
                break;
            case 2:
                textTutorial.text = "Use the [LMB] to attack";
                PlayTutorial();
                break;
            case 3:
                goLife.SetActive(true);
                break;
            case 4:
                textTutorial.text = "Press [E] to consume a can and heal yourself";
                goItem.SetActive(true);
                PlayTutorial();
                break;
            case 5:
                textTutorial.text = "Press [ESC] to pause the game and view the controls at any time";
                StartCoroutine(TutorialToObjective());
                PlayTutorial();
                break;
            default:
                textTutorial.text = null;
                break;
        }

    }
    IEnumerator TutorialToObjective()
    {
        yield return new WaitForSeconds(10f);
        goObjective.SetActive(true);
        goTutorialParent.SetActive(false);
        PlayTutorial();
    }
    public void PlayTutorial()
    {
        audioSource.PlayOneShot(tutorialClip, 0.25f);
    }
}
