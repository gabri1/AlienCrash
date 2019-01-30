using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{

    public CharacterController2D controller;
    public Animator animator;

    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        controller.Move(Input.GetAxis("Horizontal") * speed * Time.fixedDeltaTime,false,Input.GetButton("Jump"));
        animator.SetFloat("speed",Mathf.Abs(Input.GetAxis("Horizontal")));
    }
}
