using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class showFPS : MonoBehaviour
{
    public static float fps;
    TextMeshProUGUI fpsText;

    private void Awake()
    {
        fpsText = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        fps = 1.0f / Time.deltaTime;
        fpsText.text = "FPS: " + (int)fps;
    }
}
