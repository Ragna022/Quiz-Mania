using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset textJSON;

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
    }


    public TestquizList myTestquizList = new TestquizList();
    // Start is called before the first frame update
    void Start()
    {
        myTestquizList = JsonUtility.FromJson<TestquizList>(textJSON.text);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
