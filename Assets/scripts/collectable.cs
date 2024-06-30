using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collectable : MonoBehaviour
{
    public logicScript logic;




    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if(gameObject.tag == "collectable")
            {
                Destroy(gameObject);
                logic.addScore(1);
            }
        }
    }
}
