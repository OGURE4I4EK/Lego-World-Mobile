using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scissorsAction : MonoBehaviour
{
    [SerializeField] GameObject actionScisBtn;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            actionScisBtn.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            actionScisBtn.SetActive(false);
    }
}
