using Newtonsoft.Json;
using System;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;


public class QuizJsonFileReader : MonoBehaviour
{   
    public QuizManager quizManagerPixelmonModsAddonsRef;
    public QuizJsonStructure.QuestionsList questList =
     new QuizJsonStructure.QuestionsList();

    [HideInInspector] public Text PrefabText;
    
    public void ParseQuizJson(string json)
    {   
        Debug.Log("Parsing..");

        questList = JsonConvert.DeserializeObject<QuizJsonStructure.QuestionsList>(json);

        quizManagerPixelmonModsAddonsRef.CurrentQuestionNumber = 1;
    
        quizManagerPixelmonModsAddonsRef.StartQuiz();
        Debug.Log("Colouring..");

        
        
        

    }
    public void ActiveProgressCount(int i, GameObject obj){

        int j = quizManagerPixelmonModsAddonsRef.CurrentQuestionNumber;
        
        if(i+1 == j){ 

            obj.GetComponentInChildren<Text>().color = quizManagerPixelmonModsAddonsRef.FigmaDesignYellow;
            obj.GetComponent<CanvasGroup>().alpha = 1f;
            return;
        }

        else{
            if(j < i+1){
                obj.GetComponentInChildren<Text>().color = Color.white;
                obj.GetComponent<CanvasGroup>().alpha = 0.3f;   
            }
            
            else{
                obj.GetComponentInChildren<Text>().color = quizManagerPixelmonModsAddonsRef.FigmaDesignYellow;
                obj.GetComponent<CanvasGroup>().alpha = 1f;
            }
        }
        

    }
}