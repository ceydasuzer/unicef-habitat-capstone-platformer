using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyScript : MonoBehaviour
{
    public int hp = 100;
    private GameObject player;
    
    public int bossHealth = 200;

    private NavMeshAgent navMesh;
    float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        navMesh = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("player");
    }



    public void damage(int damageAmount)
    {
        hp = hp - damageAmount;

        bossHealth = bossHealth - damageAmount;

        if( hp <= 0)
        {
            Destroy(gameObject);
        }

        if (bossHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public  int currentHP()
    {
        return hp;
    }

    // Update is called once per frame
    void Update()
    {
        if(player != null && player.activeSelf)
        {
            navMesh.SetDestination(player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
        }
    }
}
