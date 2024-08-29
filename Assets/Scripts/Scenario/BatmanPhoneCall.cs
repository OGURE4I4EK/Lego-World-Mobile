using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BatmanPhoneCall : MonoBehaviour
{
    [SerializeField] GameObject destroyedWindow;
    [SerializeField] GameObject kitchenWindow;
    [SerializeField] GameObject batman;

    private AudioSource audioSource;
    [SerializeField] private AudioClip batmanHelpClip;
    private UnityEvent batmanHelpAction;

    bool isPlayAudioClip = false;
    bool batmanInKitchen = false;

    private bool batmanHelpEnded = false;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        batmanHelpAction = new UnityEvent();
        batmanHelpAction.AddListener(BatmanHelpListener);
    }

    private void BatmanHelpListener()
    {
        if (isPlayAudioClip == false && batmanInKitchen == false)
        {
            audioSource.clip = batmanHelpClip;
            audioSource.Play();
            isPlayAudioClip = true;
        }
        else
        {
            destroyedWindow.SetActive(true);
            destroyedWindow.GetComponent<AudioSource>().Play();
            Destroy(kitchenWindow);
            batman.SetActive(true);
            batmanHelpEnded = true;
        }
    }
    private void Update()
    {
        if (isPlayAudioClip)
        {
            if (audioSource.isPlaying == false)
            {
                isPlayAudioClip = false;
                batmanInKitchen = true;
                batmanHelpAction.Invoke();
            }
        }
    }

    public void StartScenario()
    {
        if (batmanHelpEnded == false)
        {
            batmanHelpEnded = true;
            batmanHelpAction.Invoke();
        }
    }
}
