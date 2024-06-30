using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stairScript : MonoBehaviour
{
    public Transform stairCam;
    public GameObject cam;
    public float camMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {


        if(collision.gameObject.name== "Player")
        {

            print("player on stairs");
            
            cam.transform.position = Vector3.Lerp(transform.position, stairCam.transform.position, camMoveSpeed * Time.deltaTime);

        }
    }
}
