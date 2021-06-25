using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody RDBDenemy;
    public Transform JugadorASeguir;
    public Vector3 rec;
    public float Speed = 4;
    public float HP = 100;
    public bool EnArea;

    void Start()
    {
        RDBDenemy = GetComponent<Rigidbody>();
        JugadorASeguir = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        EnArea = false;
    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        if (EnArea == true)
        {
            rec = (JugadorASeguir.transform.position - transform.position).normalized * Speed;
            Vector3 vel = RDBDenemy.velocity;
            vel.x = rec.x;
            vel.z = rec.z;
            RDBDenemy.velocity = vel;
        }
    }
}
