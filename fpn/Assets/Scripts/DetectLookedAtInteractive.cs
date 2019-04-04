﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectLookedAtInteractive : MonoBehaviour
{
    [Tooltip("starting point of raycast used to detect interactives")]
    [SerializeField]
    private Transform raycastOrigin;

    [Tooltip("how far from the raycastOrigin we will search for interactive elements")]
    [SerializeField]
    private float maxRange = 5.0f;

    public static event Action<IInteractive> LookedAtInteractiveChanged;
    public IInteractive lookatinteractive
    {
        get { return lookedAtInteractive; }
        private set
        {
            bool isInteractiveChanged = value != lookedAtInteractive;
            if (isInteractiveChanged)
            {
                lookedAtInteractive = value;
                LookedAtInteractiveChanged.Invoke(lookedAtInteractive);
            }
        }
    }

    private IInteractive lookedAtInteractive;


    private void FixedUpdate()
    {
        lookedAtInteractive = getlookedatinteractive();
    }

    private IInteractive getlookedatinteractive()
    {
        RaycastHit hitInfo;
        bool objectWasDetected = Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hitInfo, maxRange);
        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward * maxRange, Color.red);

        IInteractive interactive = null;

        lookedAtInteractive = interactive;

        if (objectWasDetected)
        {
            Debug.Log("Player is looking at: " + hitInfo.collider.gameObject.name);
            interactive = hitInfo.collider.gameObject.GetComponent<IInteractive>();
        }
        

        return interactive;
    }
}
