using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static QuizManager;
using 

public class Quizz : MonoBehaviour
{
    public TextAsset textJSON;
    [SerializeField] QuizUI quizUI;
    [SerializeField]
    private Testquiz selectedTestquiz;
    private List<Testquiz> testquizList;
    

    [System.Serializable]
    public class Testquiz
    {
        public string question;
        public string[] options;
        public string rightans;
    }

    [System.Serializable]
    public class TestquizList
    {
        public Testquiz[] testquiz;
        internal readonly int Count;
    }
   

    public TestquizList myTestquizList = new TestquizList();
    // Start is called before the first frame update
    void Start()
    {
        myTestquizList = JsonUtility.FromJson<TestquizList>(textJSON.text);
        SelectQuestion();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SelectQuestion()
    {
        int val = Random.Range(0, myTestquizList.Count);
        selectedTestquiz = testquizList[val];
       
        quizUI.SetQuestion(selectedTestquiz);

    }
    public bool Answer(string answered)
    {

        bool rightans = false;
        if (answered == selectedTestquiz.rightans)
        {
            //yes
            rightans= true;
        }
        else
        {
            //No
        }
        Invoke("SelectedQuestion", 0.4f);
        return rightans;
    }

}
