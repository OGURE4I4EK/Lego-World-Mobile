using DialogueEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatmanDialogue : MonoBehaviour
{
    [SerializeField] NPCConversation batmanConversation;
    [SerializeField] GameObject batman;
    [SerializeField] GameObject dialogueCanvas;
    [SerializeField] GameObject GameCanvas;

    private void Start()
    {
        batmanConversation = GetComponent<NPCConversation>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            GameCanvas.SetActive(false);
            StartDialogue();
        }
    }

    private void StartDialogue()
    {
        dialogueCanvas.SetActive(true);
        ConversationManager.Instance.StartConversation(batmanConversation);
    }
    public void deleteBatman()
    {
        Destroy(batman);
    }
}
