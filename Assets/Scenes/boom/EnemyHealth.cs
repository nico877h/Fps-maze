using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] float HealthPoints = 100f;

    public void TakeDamage(float damage)
    {
        HealthPoints -= damage;

        
        if (HealthPoints <=0)
        {
            Destroy(gameObject);
        }

    } 

}
