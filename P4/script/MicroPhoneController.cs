using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MicroPhoneController : MonoBehaviour
{

     public Button m_Record, m_Stop, m_Play, m_Pause;
     public delegate void micro();
     public static event micro eventoMicroOn;
     public static event micro eventoMicroff;

     public static event micro eventoPlaying;

     public static event micro eventoPause;


    // Start is called before the first frame update
    void Start()
    {
        m_Record.onClick.AddListener(m_Reproduce_Clicked);
        m_Stop.onClick.AddListener(m_Stop_Clicked);
        m_Play.onClick.AddListener(m_Play_Clicked);
        m_Pause.onClick.AddListener(m_Pause_Clicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void m_Reproduce_Clicked(){
        eventoMicroOn();

    }

    void m_Stop_Clicked(){
        eventoMicroff();
    }

    void m_Play_Clicked(){
        eventoPlaying();

    }
    void m_Pause_Clicked(){
        eventoPause();
    }

}
