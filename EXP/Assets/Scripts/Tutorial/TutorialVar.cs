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
}
