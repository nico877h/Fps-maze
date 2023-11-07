using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float damage = 20f;
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag =="Enemy")
        {
            EnemyHealth enemyHealth = other.gameObject.GetComponent<EnemyHealth>();
            enemyHealth.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    
}
