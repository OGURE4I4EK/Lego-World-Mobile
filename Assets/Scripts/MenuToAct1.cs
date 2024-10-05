using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuToAct1 : MonoBehaviour
{
    public void toAct1()
    {
        SceneManager.LoadScene("Act1");
    }
    public void toAct1B()
    {
        SceneManager.LoadScene("Act1Bad");
    }

    public void exit()
    {
        Application.Quit();
    }
}
