using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI subtitles;

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

}
