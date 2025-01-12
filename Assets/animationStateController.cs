using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        Debug.Log(animator);
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalkingF = animator.GetBool("isWalkingF");
        bool isWalkingB = animator.GetBool("isWalkingB");
        bool forwardPressed = Input.GetKey("w");
        bool backwardPressed = Input.GetKey("s");
        if (!isWalkingF && forwardPressed)
        {
            animator.SetBool("isWalkingF", true);
        }
        if (isWalkingF && !forwardPressed)
        {
            animator.SetBool("isWalkingF", false);
        }
        if (!isWalkingB && backwardPressed) 
        {
            animator.SetBool("isWalkingB", true);
        }
        if (isWalkingB && !backwardPressed)
        {
            animator.SetBool("isWalkingB", false);
        }

    }
}
