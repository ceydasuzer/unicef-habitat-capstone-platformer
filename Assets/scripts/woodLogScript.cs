using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class woodLogScript : MonoBehaviour
{
    public GameObject hiddenBridge;
    private int currentLogCount = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if(gameObject.name == "firstLog")
            {
                currentLogCount = 1;
                Destroy(gameObject);

            }
            
            if(gameObject.name == "secondLog")
            {
                currentLogCount = 2;
                Destroy(gameObject);

            }
            if (gameObject.name == "thirdLog")
            {
                currentLogCount = 3;
                Destroy(gameObject);

            }
            if (gameObject.name == "fourthLog")
            {
                currentLogCount = 4;
                Destroy(gameObject);

            }

            if (currentLogCount == 4)
            {
                showBridge();
            }

        }


    }

    private void showBridge()
    {
        hiddenBridge.SetActive(true);
    }
}
