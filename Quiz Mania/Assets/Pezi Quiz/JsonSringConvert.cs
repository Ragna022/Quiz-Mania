using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Networking;


public class JsonSringConvert : MonoBehaviour
{    
    public QuizJsonFileReader quizJsonFileReaderPixelmonMods;
    //string _QuizPathToContent = "quiz-pixelmon/document_1.json";
    //string _NameGeneratorPathToContent = "name-generator/names.json";

    [TextArea]
    public string _Quizjsonstring;

    private void DesearilizeQuizJsonPixelmonModsAddonsRef(string json){

        if(string.IsNullOrEmpty(json)){
            Debug.LogError("No Json");
            return;
        }

        _Quizjsonstring = json;
        
        quizJsonFileReaderPixelmonMods.ParseQuizJson(_Quizjsonstring);;
        
        
    }

    void Start()
    {
        DesearilizeQuizJsonPixelmonModsAddonsRef(_Quizjsonstring);
    }
    
}

