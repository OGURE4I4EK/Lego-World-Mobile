using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGlassInSisterRoom : MonoBehaviour
{
    Rigidbody[] glassRb;

    private void Start()
    {
        glassRb = GetComponentsInChildren<Rigidbody>();
        Invoke(nameof(glass), 30f);
    }

    private void glass()
    {
            for (int i = 0; i < glassRb.Length; i++)
            {
                glassRb[i].isKinematic = false;
            }
    }
}
