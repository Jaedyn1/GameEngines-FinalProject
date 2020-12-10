using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private Rigidbody rb;
    public Animator animator;
    public CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 4.0f;
  //  private float jumpHeight = 1.0f;
   // private float gravityValue = -9.81f;
    public Vector3 lastPosition;
    public int attackcount;
    private static CharacterMovement playerInstance;



    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }




        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * playerSpeed);
        //horizontal(x,y,z) Input.GetAxis("Horizontal")



        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

   



        if (Input.GetMouseButtonDown(1))
        {
            
            animator.SetTrigger("Attack");
            attackcount++;
            Debug.Log(attackcount);
            if(attackcount >= 5 && Input.GetMouseButtonDown(1))
            {
                animator.SetTrigger("Heaveattack");
                attackcount = 0;
            }

        }


        float speed = Vector3.Distance(lastPosition, transform.position) / Time.deltaTime;
        animator.SetFloat("Speed", speed);
        lastPosition = this.transform.position;

    }
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
}
