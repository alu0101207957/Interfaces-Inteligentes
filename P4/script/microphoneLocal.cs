using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class microphoneLocal : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        MicroPhoneController.eventoMicroOn += Recording;
        MicroPhoneController.eventoMicroff += Stop;
        MicroPhoneController.eventoPause += Pause;
        MicroPhoneController.eventoPlaying += Play;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Play(){
        audioSource.Play();
    }

    void Pause(){
        audioSource.Pause();
    }
    void Recording(){
        audioSource.clip =  Microphone.Start("Micrófono (FIFINE K669 Microphone)",true, 10, 44100);
    }

    void Stop(){
        Microphone.End("Micrófono (FIFINE K669 Microphone)");
    }
}
