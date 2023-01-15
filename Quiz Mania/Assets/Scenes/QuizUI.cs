using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static QuizManager;
using static Quizz;
using System;

public class QuizUI : MonoBehaviour
{
    [SerializeField] private Text questionText;
    [SerializeField] private List<Button> options;
    [SerializeField] private Color correctCOLOR, wrongCOLOR, normalCOLOR;
    [SerializeField] Quizz quizz;


    private Testquiz testquiz;
    private bool answered;
    private object quiz;
   
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void SetQuestion(Testquiz testquiz)
    {
        this.testquiz = testquiz;


        questionText.text = testquiz.question;
        List<string> answerList =JsonReader.jsonReaderItems<string>(TestquizList.options);
        for (int i = 0; i < options.Count; i++)
        {
            options[i].GetComponentInChildren<Text>().text = answerList[i];
            options[i].name = answerList[i];
            options[i].image.color = normalCOLOR;
        }
        answered = false;

       
    }

    

}
