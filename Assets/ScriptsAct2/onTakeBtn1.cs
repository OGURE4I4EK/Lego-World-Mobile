using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTakeBtn1 : MonoBehaviour
{
    [SerializeField] GameObject takeBtn1;
    [SerializeField] GameObject key;
    [SerializeField] GameObject keyInv;

    public void Action()
    {
        key.SetActive(false);
        keyInv.SetActive(true);
    }
}
