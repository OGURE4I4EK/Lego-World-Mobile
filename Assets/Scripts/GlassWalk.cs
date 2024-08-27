using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlassWalk : MonoBehaviour
{
    AudioSource audioSource;
    Rigidbody glassRb;
    [SerializeField] AudioSource brokenGlass;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        glassRb = GetComponent<Rigidbody>();   
    }

    private void Start()
    {
        brokenGlass.Play();
        Invoke(nameof(makeGlassKinematic), 5f);
        Invoke(nameof(deleteGlass), 20f);
    }
    private void makeGlassKinematic()
    {
        glassRb.isKinematic = true;
        this.gameObject.GetComponent<Collider>().isTrigger = true;
    }
    private void deleteGlass()
    {
        Destroy(this.gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }
}
