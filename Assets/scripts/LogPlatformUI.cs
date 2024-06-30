using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogPlatformUI : MonoBehaviour
{
    public GameObject woodInfo;
    public GameObject cam;
    public Transform newCamPosition;
    public float camMoveSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        woodInfo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name== "Player")
        {
            if(gameObject.tag == "logUI")
            {
                woodInfo.SetActive(true);
                //cam.transform.position = Vector3.Lerp(transform.position, newCamPosition.transform.position, camMoveSpeed * Time.deltaTime);
            }

        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Player")
        {
            if (gameObject.tag == "logUI")
            {
                woodInfo.SetActive(false);
            }
        }
    }
}
