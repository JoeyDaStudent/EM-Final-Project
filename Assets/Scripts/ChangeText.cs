using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI subtitles;
    public Slider size;
    public Slider red;
    public Slider green;
    public Slider blue;

    public void PhraseOne()
    {
        subtitles.text = "Hello my name is Mr. Carrillo.";
    }

     public void PhraseTwo()
    {
        subtitles.text = "Today we are going to talk about Lerp.";
    }

    public void PhraseThree()
    {
        subtitles.text = "Let's get started.";
    }

    private void Start()
    {
        size.maxValue = 100;
        red.maxValue = 1;
        green.maxValue = 1;
        blue.maxValue = 1;
    }
    private void Update()
    {
        subtitles.fontSize = size.value;
        subtitles.color = new Color(red.value, green.value, blue.value);
    }
}
