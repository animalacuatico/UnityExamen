using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class MarioAnims : MonoBehaviour
{
    private Animator animator;
    private MarioScript Mario;
    private void Start()
    {
        animator = GetComponent<Animator>();
        Mario = GetComponent<MarioScript>();
    }
    private void Update()
    {
        switch (Mario.GetPlayerState())
        {
            case PlayerState.IDLE:
            animator.SetBool("isRunning", false); break;
            case PlayerState.RUN:
            animator.SetBool("isRunning", true); break;
        }
    }
}
