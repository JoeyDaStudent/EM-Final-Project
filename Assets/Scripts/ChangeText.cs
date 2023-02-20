using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI subtitles;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            subtitles.text = "Hello my name is Mr. Carrillo.";
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            subtitles.text = "Today we are going to talk about Lerp.";
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            subtitles.text = "Let's get started.";
        }
    }
}
