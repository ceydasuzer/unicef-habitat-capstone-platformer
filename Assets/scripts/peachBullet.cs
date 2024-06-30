using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peachBullet : MonoBehaviour
{

    public int damageAmount = 50;


    private void OnTriggerEnter(Collider other)
    {
        enemyScript snake = other.GetComponent<enemyScript>();
        if(snake != null)
        {
            snake.damage(damageAmount);

            if(snake.currentHP() <= 0)
            {
                
                Destroy(other.gameObject);
            }
        }

    }
}
