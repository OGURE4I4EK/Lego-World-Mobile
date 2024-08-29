using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTakeBtn2 : MonoBehaviour
{
    [SerializeField] GameObject takeBtn2;
    [SerializeField] GameObject scissors;
    [SerializeField] GameObject scissorsInv;

    public void Action()
    {
        scissors.SetActive(false);
        scissorsInv.SetActive(true);
        takeBtn2.SetActive(false);
    }
}
