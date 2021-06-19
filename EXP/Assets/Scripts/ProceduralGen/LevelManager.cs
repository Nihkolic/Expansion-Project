using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public int[] seedArray;
    public bool randomSeed;
    public int seed;
    int _seed;

    public int gridX;
    public int gridz;
    float gridSpacingOffsetX = 94.47976f;
    float gridSpacingOffsetZ = 97.80977f;
    Vector3 gridOrigin = Vector3.zero;

    public GameObject[] tiles;
    private void Awake()
    {
        GenerateGrid();
    }
    void GenerateSeed()
    {
        if (randomSeed)
        {
            _seed = Random.Range(0, 9999);
        }
        else
        {
            for (int i = 0; i < seedArray.Length; i++)
            {
                _seed = seedArray[i];
            }
        }

    }
    public void GenerateGrid()
    {
        for (int x = 0; x < gridX; x++)
        {
            for (int z = 0; z < gridz; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffsetX, 0, z * gridSpacingOffsetZ) + gridOrigin;
                PickAndSpawn(spawnPosition);
            }
        }
    }
    void PickAndSpawn(Vector3 positionToSpawn)
    {
        int randomIndex = Random.Range(0, tiles.Length);
        GameObject clone = Instantiate(tiles[randomIndex], positionToSpawn, Quaternion.identity);
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
