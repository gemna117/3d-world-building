using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    private Animator animator;
    private bool isOpen = false;
    private int shouldOpenAnimParameter = Animator.StringToHash(nameof(shouldOpenAnimParameter));

    public Door()
    {
        displayText = nameof(Door);
    }

    private void Awake()
    {
        base.awake
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        base.InteractWith();
        animator.SetBool("should open", true);
        DisplayText = string.Empty;
        isOpen = true;
    }
}
