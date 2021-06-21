using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateSelf : MonoBehaviour
{
    
    void Awake()
    {
        gameObject.SetActive(false);
    }

}
