using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dedArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() == null)
        {
            Destroy(other.gameObject);
        }
    }
}
