using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    private static InventoryMenu instance;

    public InventoryMenu instance
    {
        get
        {
            if (instance == null)
                throw new System.Exception("");
            return instance;
        }
        private set { instance = value; }
    }

    private void awake()
    {
        if (instance == null)
        instance = this;
    }
}
