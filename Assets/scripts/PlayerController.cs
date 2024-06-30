using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;

    public GameObject Bridge;


    public Transform GroundCheck;
    public LayerMask ground;

    public float moveSpeed;
    public float jumpForce;

    private bool isAlive;
    private float forwardBackward, leftRight;
    private bool isJumping;


    public GameObject peachPrefab;
    public GameObject attackPoint;

     public AudioSource audioPeach;

    public logicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        audioPeach = GetComponent<AudioSource>();

        isAlive = true;

        Bridge.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        forwardBackward = Input.GetAxis("Vertical");
        leftRight = Input.GetAxis("Horizontal");

        isJumping = Input.GetKeyDown(KeyCode.Space);

        if(transform.position.y < -5)
        {
            logic.gameOver();
        }


        if( isAlive)
        {
            transform.Translate(leftRight * moveSpeed * Time.deltaTime, 0, forwardBackward * moveSpeed * Time.deltaTime);

            if (isJumping && IsGrounded())
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }

            if (Input.GetMouseButtonDown(0))
            {
                Vector3 offset = transform.forward * 2.4f + transform.up * 4f + transform.right * 1.6f;
                GameObject bullet = Instantiate(peachPrefab, attackPoint.transform.position, attackPoint.transform.rotation);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(attackPoint.transform.forward * 2000f);
                }

                bullet.AddComponent<peachBullet>();

                Destroy(bullet, 3f);

            }
        }

        anim.SetFloat("horizontal", forwardBackward);
        anim.SetFloat("vertical", leftRight);
        anim.SetBool("isJumping", isJumping);

        

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "collectable")
        {
            
            audioPeach.Play();
        }
    }

    public bool IsGrounded()
    {
        return Physics.CheckSphere(GroundCheck.position, .1f, ground);
        
    }

   
}
