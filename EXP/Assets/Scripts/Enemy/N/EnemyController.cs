using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Rigidbody RDBDenemy;
    public Transform JugadorASeguir;
    public Vector3 rec;
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;
    public float Speed = 4;
    public float HP = 100;
    public bool EnArea;
    Vector3 moveDirection;

    void Start()
    {
        RDBDenemy = GetComponent<Rigidbody>();
        JugadorASeguir = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        EnArea = false;
    }
    
    void Update()
    {
        moveDirection = Vector3.zero;

        if (Vector3.Distance(JugadorASeguir.position, this.transform.position) < 5)
        {
            Vector3 direction = JugadorASeguir.position - this.transform.position;
            direction.y = 0;

            this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
                                        Quaternion.LookRotation(direction), 0.1f);

        }
    }
    /*
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
    }*/

    public void die()
    {

        if (OnEnemyKilled != null)
        {
            OnEnemyKilled();
        }
    }  
}