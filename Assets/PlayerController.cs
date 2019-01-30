using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  
    public CharacterController2D controller;
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        controller.Move(Input.GetAxis("Horizontal"), false, false);
        animator.SetFloat("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
    }
}
