using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Player")
        {
            if(collision.GetComponent<EnemyStats>()  != null) 
            {
                collision.GetComponent<EnemyStats>().DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
