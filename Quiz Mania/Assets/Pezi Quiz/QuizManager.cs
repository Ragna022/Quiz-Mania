using System.Runtime.Serialization.Json;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QuizManager : MonoBehaviour
{   
    public static QuizManager quizManagerPixelmonModsAddonsRef;
    public QuizJsonFileReader quizJsonFileReaderPixelmonMods;
    public TextMeshProUGUI _questions;
    public TextMeshProUGUI[] _buttonTexts;
    public int TotalQuestions;
    public int CurrentQuestionNumber;

    public Color FigmaDesignYellow;
    
    public void StartQuiz(){
        
        CurrentQuestionNumber = 1;
        TotalQuestions = quizJsonFileReaderPixelmonMods.questList.questionsData.Length;  
        FillQuiz(CurrentQuestionNumber);
        quizManagerPixelmonModsAddonsRef = this;

    }

    // void Start()
    // {
    //     StartQuiz();
    // }

    public void FillQuiz(int x){
        
        _questions.text = quizJsonFileReaderPixelmonMods.questList.questionsData[x-1].questions;
        
        for (int j = 0; j < quizJsonFileReaderPixelmonMods.questList.questionsData[x-1].options.Length; j++){

            _buttonTexts[j].text = quizJsonFileReaderPixelmonMods.questList.questionsData[x-1].options[j];
        }

        int rightAnswerindex = quizJsonFileReaderPixelmonMods.questList.questionsData[x-1].options.Length;

        _buttonTexts[rightAnswerindex].text = quizJsonFileReaderPixelmonMods.questList.questionsData[x-1].rightAnswer;

    }

    public void NextQuizQuestion(){
        
        if(CurrentQuestionNumber < TotalQuestions + 1){

            CurrentQuestionNumber += 1;
            FillQuiz(CurrentQuestionNumber);

            //fix bug for next counter (step 1 -> step 2)
        }


    
    }


}