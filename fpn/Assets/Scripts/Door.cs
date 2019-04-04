using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{
    [Tooltip("check this box to lock the door")]
    [SerializeField]
    private bool isLocked;

    [Tooltip("text that displays while looking at locked door")]
    [SerializeField]
    private string lockeddisplaytext = "locked";

    [Tooltip("when players interacts with a locked door")]
    [SerializeField]
    private AudioClip lockedAudioClip;

    [Tooltip("when player opens the door")]
    [SerializeField]
    private AudioClip openAudioClip;
    public override string displaytext => isLocked ? lockeddisplaytext : base.displayText;

    
     //   public override string DisplayText
   // {
   //     get
     //   {
       //     if (isLocked)
         //       return lockeddisplaytext;
           // else
             //   return base.displayText;
       // }
 //   }
    

    private Animator animator;
    private bool isOpen = false;
    private int shouldOpenAnimParameter = Animator.StringToHash ("shouldOpen");

    public Door()
    {
        DisplayText = nameof(Door);
    }

    protected override void Awake()
    {
        base.awake();
        animator = GetComponent<Animator>();
    }

    public override void InteractWith()
    {
        if (!isOpen)
        {
            if (!isLocked)
            {
            audioSource.clip = openAudioClip;
            animator.SetBool(shouldOpenAnimParameter, true);
            displayText = string.Empty;
            isOpen = true;
            }
            else
            {
                
            }
            base.interactwith();
        }
        else
        {
            
        }
    }
}
