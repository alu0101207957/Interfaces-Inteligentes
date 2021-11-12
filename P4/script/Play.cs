using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play : MonoBehaviour
{
     public Button m_Reproduce, m_Stop;
     public delegate void webcam();
     public static event webcam eventoWebcamOn;
     public static event webcam eventoWebcamOff;

    void Start()
    {
        //Calls the TaskOnClick/TaskWithParameters/ButtonClicked method when you click the Button
        m_Reproduce.onClick.AddListener(m_Reproduce_Clicked);
        m_Stop.onClick.AddListener(m_Stop_Clicked);

    }

    void m_Reproduce_Clicked()
    {
        Debug.Log("Reproduce Button Clicked");
        eventoWebcamOn();
    }

      void m_Stop_Clicked()
    {
        Debug.Log("Stop Button Clicked");
        eventoWebcamOff();
    }
}

