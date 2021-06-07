using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyToSpawn;
    public Transform[] spawnPoints;
    BoxCollider trigger;


   private void Start()
   {
        trigger = GetComponent<BoxCollider>();
   }

   private void OnTriggerEnter(Collider other)
   {
        if(other.tag == "PlayerCollider")
        {
            SpawnEnemies();
            trigger.enabled = false;
        }
   }

    void SpawnEnemies()
    {
        //Instantiate(enemyToSpawn, spawnPoints[0].position, spawnPoints[0].rotation);
        
        foreach(var sp in spawnPoints)
        {
            Instantiate(enemyToSpawn, sp.position, sp.rotation);
        }
    }
}
