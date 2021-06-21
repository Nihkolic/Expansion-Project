using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshBaker : MonoBehaviour
{
    [SerializeField] NavMeshSurface navMeshSurfaces;
    void Awake()
    {
        //navMeshSurfaces.BuildNavMesh();
    }
}
