using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    [SerializeField] GameObject goTutorial;
    Text textTutorial;
    //bool activated = false;

    [Header("HUD")]
    [SerializeField] GameObject goItem;
    [SerializeField] GameObject goWeapon;
    [SerializeField] GameObject goLife;
    private void Start()
    {
        

    }
    void Step()
    {
        goTutorial.SetActive(true);
        textTutorial = goTutorial.GetComponent<Text>();


        textTutorial.text = "Use [W][A][S][D] to move and [Space] to Jump";
        textTutorial.text = "Use the [RMB] to Attack";
        textTutorial.text = "Press [E] to Heal";
        textTutorial.text = "Press [ESC] pause the game and view the controls at any time";
    }
}
