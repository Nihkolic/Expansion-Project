using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject goSlot;
    //public bool full;
    public Text numText;
    public int num = 0;

    public KeyCode healKey = KeyCode.E;
    public PlayerHealth health;
    private void Start()
    {
        numText.text = "0";
    }
    public void UpdateNum()
    {
        numText.text = num.ToString();
        if (num <= 0)
        {
            num = 0;
        }
    }     
    private void Update()
    {
        if ((Input.GetKeyDown(healKey))&&(num>=1))
        {
            if (health.hp < health.hpMax) 
            {
                health.Heal(3);
                num -= 1;
                UpdateNum();
            }
        }
    }
}
