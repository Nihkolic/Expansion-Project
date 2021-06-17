using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{

    public Tile[] tiles;
    public int[] seed;

    private void Start()
    {
        
    }
    public void Generatelevel()
    {
        //Vector3 lastPosition = Vector3.zero;

        for (int i = 0; i < seed.Length; i++)
        {

        }
    }
    public void GenerateMap()
    {
        int[,] map = new int[3, 3]
        {
            {6, 7, 8 },
            {4,-1, 5 },
            {1, 2, 3 }
        };
        /*
        for (int i = 0; i < length; i++)
        {
            for (int i = 0; i < length; i++)
            {

            }
        }*/
    }
}
