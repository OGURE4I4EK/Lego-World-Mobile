using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTake2 : MonoBehaviour
{
    [SerializeField] GameObject onTakeBtn2;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            onTakeBtn2.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            onTakeBtn2.SetActive(false);
    }
}
