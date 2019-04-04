using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithLookedAt : MonoBehaviour
{
    private IInteractive lookedAtInteractive;
    void Update()
    {
        if (Input.GetButton("interact") && detectLookedAtInteractive.lookedAtInteractive != null)
        {
            Debug.Log("player pressed the interact button");
            lookedAtInteractive.interactivewith();
            
        }
    }

    private void onlookedatinteractivechanged(IInteractive newLookedAtInteractive)
    {
        lookedAtInteractive = newLookedAtInteractive;
    }

    #region event subscription / unsubscription
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }
    #endregion
}
