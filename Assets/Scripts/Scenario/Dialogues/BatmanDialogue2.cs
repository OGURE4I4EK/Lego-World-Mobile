using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatmanDialogue2 : MonoBehaviour
{
    [SerializeField] NPCConversation batmanConversation2;


    private void Awake()
    {
        batmanConversation2 = GetComponent<NPCConversation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            StartDialogue();
        }
    }
    private void StartDialogue()
    {
        ConversationManager.Instance.StartConversation(batmanConversation2);
    }
}