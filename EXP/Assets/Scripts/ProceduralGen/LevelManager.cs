using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int[] seed;
    float gridSpacingOffsetX = 94.47976f;
    float gridSpacingOffsetZ = 97.80977f;
    public Vector3 gridOrigin = Vector3.zero;
    public GameObject[] tiles;
    private void Awake()
    {
        GenerateMap();
    }
    public void GenerateMap()
    {
        int[,] map = new int[3, 3]
        {
            {seed[7], seed[8], seed[9]},
            {seed[4], seed[5], seed[6]},
            {seed[1], seed[2], seed[3]}
        };
        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int col = 0; col < map.GetLength(1); col++)
            {
                int index = map[row, col];
                if(index == -1)
                {
                    continue;
                }
                GameObject clone = Instantiate(tiles[index]);
                clone.transform.position = new Vector3(col * gridSpacingOffsetX, 0, -row * gridSpacingOffsetZ) + gridOrigin;
            }
        }
    }
}
