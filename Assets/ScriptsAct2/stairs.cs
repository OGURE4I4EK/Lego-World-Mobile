using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class stairs : MonoBehaviour
{
    [SerializeField] GameObject sister;
    [SerializeField] GameObject sister2;
    [SerializeField] GameObject player;
    [SerializeField] GameObject player2;
    [SerializeField] GameObject batman;
    [SerializeField] GameObject batman2;
    [SerializeField] GameObject stair;
    [SerializeField] AudioSource all;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
        {
            player.SetActive(false);
            sister.SetActive(false);
            batman.SetActive(false);
            stair.SetActive(false);
            player2.SetActive(true);
            batman2.SetActive(true);
            sister2.SetActive(true);
            all.Play();
            Invoke(nameof(Act3), 1.06f);
        }
    }
    void Act3()
    {
        SceneManager.LoadScene("HappyEnd");
    }
}
