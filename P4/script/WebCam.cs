using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WebCam : MonoBehaviour
{
    // Start is called before the first frame update
    WebCamTexture webcamTexture;
    void Start()
    {
        webcamTexture = new WebCamTexture();
        Renderer renderer = GetComponent<Renderer>();
        Play.eventoWebcamOn += reproduceVideo;
        Play.eventoWebcamOff += stopVideo;
      
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void reproduceVideo(){
        Debug.Log("Reproduce Video Event Actived");
          GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

     void stopVideo(){
        
        Debug.Log("Stop Video Event Actived");
        GetComponent<Renderer>().material.mainTexture = webcamTexture;
        webcamTexture.Stop();
        
    }
}
