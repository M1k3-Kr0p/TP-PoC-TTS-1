using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpeechLib;
using UnityEngine.UI;


public class Audio_Synthesizer : MonoBehaviour
{
    public UnityEngine.UI.Text txt;
    // Start is called before the first frame update
    void Start()
    {
        SpVoice voice;
        voice = new SpVoice();
        voice.Voice = voice.GetVoices().Item(1);
        voice.Speak("This is text that was translated to speech. This is a proof of concept for the horizon world.");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
