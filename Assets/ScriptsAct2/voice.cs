using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class voice : MonoBehaviour
{
    [SerializeField] AudioSource start;
    [SerializeField] AudioSource end;

    private void Awake()
    {
        start.Play();
        Invoke(nameof(endi), 3f);
    }
    void endi()
    {
        end.Play();
    }
}
