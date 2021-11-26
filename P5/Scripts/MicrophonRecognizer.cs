using System;

using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.Windows.Speech;


public class MicrophonRecognizer : MonoBehaviour
{
    public Button keyRecognizerButton;
    private bool record = false;


    public Button dictationButton;
    private bool dictation = false;

    private bool forward = false;
    private bool backward = false;
    private bool right = false;
    private bool left = false;

    [SerializeField]
    private string[] m_Keywords;
    private KeywordRecognizer m_Recognizer;

    private DictationRecognizer m_DictationRecognizer;
    public Text textoDictado;


    // Start is called before the first frame update
    void Start()
    {
        m_Recognizer = new KeywordRecognizer(m_Keywords);
        m_Recognizer.OnPhraseRecognized += OnPhraseRecognized;
        Button btnRecognizer = keyRecognizerButton.GetComponent<Button>();
		btnRecognizer.onClick.AddListener(TaskOnClickRecognizer);


        m_DictationRecognizer = new DictationRecognizer();

        m_DictationRecognizer.DictationResult += (text, confidence) =>
        {   textoDictado.text += " ";
            textoDictado.text += text;
                Debug.LogFormat("Dictation result: {0}", text);
        };

           m_DictationRecognizer.DictationComplete += (completionCause) =>
        {
            if (completionCause != DictationCompletionCause.Complete)
                Debug.LogErrorFormat("Dictation completed unsuccessfully: {0}.", completionCause);
        };

        Button btnDictation = dictationButton.GetComponent<Button>();
		btnDictation.onClick.AddListener(TaskOnClickDictation);
    }

    void TaskOnClickRecognizer(){
		record = !record;
        if (record){    
            if(dictation){
                m_DictationRecognizer.Stop();
		PhraseRecognitionSystem.Shutdown();
                m_DictationRecognizer.Dispose();
		
            }
            m_Recognizer.Start();
        } else {
            m_Recognizer.Stop();
            m_Recognizer.Dispose();
        }
        dictation = false;
	}

    void TaskOnClickDictation(){
        dictation = !dictation;
       
        if (dictation){    
            if(record){
                m_Recognizer.Stop();
                 m_Recognizer.Dispose();
            }
            m_DictationRecognizer.Start();
            textoDictado.text = "Dictado: ";
        } else {
            m_DictationRecognizer.Stop();
            m_DictationRecognizer.Dispose();
        }
        record = false;
    }

    private void OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
         StringBuilder builder = new StringBuilder();
        builder.AppendFormat("{0} ({1}){2}", args.text, args.confidence, Environment.NewLine);
        builder.AppendFormat("\tTimestamp: {0}{1}", args.phraseStartTime, Environment.NewLine);
        builder.AppendFormat("\tDuration: {0} seconds{1}", args.phraseDuration.TotalSeconds, Environment.NewLine);
        Debug.Log(builder.ToString());
        if (args.confidence == ConfidenceLevel.High || args.confidence == ConfidenceLevel.Medium)
        {
            if(args.text == "Adelante"){
                forward = true;
                backward = false;
            }
            else if (args.text == "Atras"){
                backward = true;
                forward = false;
            } else if (args.text == "Derecha"){
                right = true;
                left = false;
            } else if (args.text == "Izquierda"){
                left = true;
                right = false;
            } else if (args.text == "Para"){
                forward = false;
                backward = false;
                right = false;
                left = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(forward){
            gameObject.transform.position += Vector3.forward * Time.deltaTime;
        }  
        if(backward) {
            gameObject.transform.position += Vector3.back * Time.deltaTime;
        }
          if(left) {
            gameObject.transform.position += Vector3.left * Time.deltaTime;
        }
          if(right) {
            gameObject.transform.position += Vector3.right * Time.deltaTime;
        }
    }
}
