using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static JsonReader;
using static QuizManager;

public class QuizManager : MonoBehaviour
{
    [SerializeField]
    public List<Question> JsonReader;
    public class TestquizList
    {
        public Testquiz[] testquiz;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public class Testquiz
    {
        public string question;
        public string[] options;
        public string rightans;
    }

    public class Question
    {
        public string questionInfo;
        public List<string> options;
        public QuestionType questionType;
        public string rightans;
    }
    [System.Serializable]

    public enum QuestionType
    {
        TEXT
    }
}
