using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Detect : MonoBehaviour
{
    public Enemy enemy;
    public LayerMask layerMask;

    void OnDrawGizmos()
    {

        int i = 1;
        Collider[] hitColliders;

        hitColliders = Physics.OverlapBox(transform.position, new Vector3(15, 2.4f, 15) / 2, transform.rotation, layerMask, QueryTriggerInteraction.Collide);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(15, 2.4f, 15));

        if (i < hitColliders.Length)
        {
            enemy.EnArea = true;
            Gizmos.color = Color.green;
            Gizmos.DrawWireCube(transform.position, new Vector3(15, 2.4f, 15));
        }
    }
}
