using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    Dictionary<string, bool> findObjects = new Dictionary<string, bool>();


    private void Awake()
    {
    }

    private void Start()
    {
        findObjects.Add("photo", false);

    }

    public void FindObject(string name)
    {
        findObjects[name] = true;
    }

    public bool CheckFirstQuestEnded()
    {
        foreach(var item in findObjects)
        {
            if (item.Value == false)
            {
                return false;
            }
        }
        return true;
    }
}
