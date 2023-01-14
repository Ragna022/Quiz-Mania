using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class JsonSaveSystem : MonoBehaviour
{
    public InputField questionInputField;


    public void SaveToJson()
    {
        Quizmania data = new Quizmania();
        data.Question = questionInputField.text;
        string json = JsonUtility.ToJson(data, true);
        File.WriteAllText(Application.dataPath + "/QuizmaniaFile.Json", json);
    }


    public void LoadFromJson()
    {
        string json = File.ReadAllText(Application.dataPath + "/QuizmaniaFile.Json");
        Quizmania data = JsonUtility.FromJson <Quizmania>(json);

        questionInputField.text = data.Question;
    }

}

