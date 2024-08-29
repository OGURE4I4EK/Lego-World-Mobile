using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundFall : MonoBehaviour
{
    [SerializeField] AudioSource fallS;
    int o = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            if (o == 0)
            {
                o++;
                fallS.Play();
            }
        }
    }
}
