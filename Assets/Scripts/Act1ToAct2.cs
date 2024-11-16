using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Act1ToAct2 : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    [SerializeField] GameObject canvas2;
    [SerializeField] GameObject a;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>() != null)
            canvas.SetActive(false);
            canvas2.SetActive(true);
    }
}
