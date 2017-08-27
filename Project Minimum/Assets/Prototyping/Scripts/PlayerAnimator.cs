using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    Animator animator;
    Rigidbody rb;
    public float speedPercent;
    const float animationSmoothing = .1f;

    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        speedPercent = rb.velocity.magnitude;
        animator.SetFloat("speedPercent", speedPercent, animationSmoothing, Time.deltaTime);
	}
}
