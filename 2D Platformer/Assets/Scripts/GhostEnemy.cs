using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostEnemy : MonoBehaviour
{
    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if(health <= 0) // Check to see if the enemys health has been depleated to 0 or less
        {
            Death(); // Run Death method
        }
    }

    void Death()
    {
        Destroy(gameObject); // Destorys the enemy
    }
}
