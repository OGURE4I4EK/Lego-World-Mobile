using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class lyuk1 : MonoBehaviour
{
    [SerializeField] MeshRenderer luk;
    [SerializeField] AudioSource lyuke;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null || other.gameObject.GetComponent<NavMeshAgent>() != null)
        {
            luk.enabled = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null || other.gameObject.GetComponent<NavMeshAgent>() != null)
        {
            luk.enabled = true;
        }
    }
}
