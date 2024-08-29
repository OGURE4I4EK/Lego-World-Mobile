using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyAction : MonoBehaviour
{
    [SerializeField] GameObject actionKeyBtn;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            actionKeyBtn.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            actionKeyBtn.SetActive(false);
    }
}
