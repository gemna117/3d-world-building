using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class Door : InteractiveObject
{

    [Tooltip("key to open a locked door")]
    [SerializeField]
    private InventoryObject key;
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


    public override string displaytext()
    {
        get
            {
            string toReturn;

            if (isLocked)
                toReturn = hasKey ? $"Use {key.objectName}" : lockeddisplaytext;
            else
                toReturn base.displayText;
            return toReturn;
        }
    }

    private bool hasKey => PlayerInventory.InventoryObjects.Contains(key);
    private Animator animator;
    private bool isOpen = false;
    private bool isLocked;
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
            }
            else
            {
                animator.SetBool(shouldOpenAnimParameter, true);
                displayText = string.Empty;
                isOpen = true;
                unlockdoor();
            }
            base.interactwith();
        }
        else
        {
            
        }
    }

    private static void unlockdoor()
    {
        isLocked = false;
        if (key != null && containsKey)
            PlayerInventory.InventoryObject.Remove(key);
    }
}
