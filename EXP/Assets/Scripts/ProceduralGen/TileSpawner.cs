using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject R;
    private void Start()
    {
        Instantiate(R, transform.position,Quaternion.identity);
    }
}

