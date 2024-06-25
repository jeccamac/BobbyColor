using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectBook : MonoBehaviour
{
    private Animator animator;

    private void Start() 
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tap on book");
        if (animator != null)
        {
            animator.Play("Select");
            Debug.Log("play select animation");
        }
    }
}
