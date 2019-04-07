using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryObject : InteractiveObject
{
    [Tooltip("name of the object")]
    [SerializeField]
    private string objectName;

    [Tooltip("text for when the player selects an inventory object")]
    [SerializeField]
    private string description;

    [Tooltip("icon to display for item")]
    [SerializeField]
    private Sprite icon;
    private new Renderer renderer;
    private new Collider collider;

    public void Start()
    {
        renderer = GetComponent<Renderer>();
        collider = GetComponent<Collider>();
    }

    public InventoryObject()
    {
        displayText = nameof(InventoryObject);
    }

    public override void interactwith()
    {
        base.interactwith();
        PlayerInventory.InventoryObject.Add(this);
        renderer.enabled = false;
        collider.enabled = false;
    }
}
