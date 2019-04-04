using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class InteractiveObject : MonoBehaviour, IInteractive
{
    [SerializeField]
    protected string displayText = nameof(InteractiveObject);
    public string DisplayText => displayText;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void interactwith()
    {
        try
        {
        audioSource.Play();
        }
        catch (System.Exception)
        {
            throw new System.Exception("");
        }
        Debug.Log($"player just interacted with {gameObject.name}.");
    }
}
