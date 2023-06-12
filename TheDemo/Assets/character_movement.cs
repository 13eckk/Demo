using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_movement : character
{
    private CharacterController controller;
    private Animator Animator;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++MOVEMENTCONTROLLER+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++     

        movementController();
        animate();
        
        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++MOVEMENTCONTROLLER+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    }
    void animate()
    {
        if (Input.GetAxis("Vertical") == 1)
        {
            Animator.SetBool("Walk", true);
        }
        else
        {
            Animator.SetBool("Walk", false);
        }
        if (Input.GetAxis("Vertical") == -1)
        {
            Animator.SetBool("WalkBackWard", true);
        }
        else
        {
            Animator.SetBool("WalkBackWard", false);
        }
        if (true)
        {

        }
    }
    void movementController()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(move * Time.deltaTime * movement_speed);
        if (Input.GetAxis("Vertical") == 1 && Input.GetKey(KeyCode.LeftShift))
        {
            movement_speed = 2;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            movement_speed = 0;
        }
    }
}
