using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    public Animator animator;

    
    private Rigidbody rb;

    private int speedHash;
    private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        speedHash = Animator.StringToHash("Speed");
    }

    // Update is called once per frame
    void Update()
    {
        speed = rb.linearVelocity.magnitude;
        animator.SetFloat(speedHash, speed);
    }
}
