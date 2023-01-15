using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class QuizJsonStructure : MonoBehaviour
{
    [System.Serializable]
    public class QuestionsList
    {
        [JsonProperty("testquiz")] public Questions[] questionsData;
    }

    [System.Serializable]
    public class Questions
    {   
        //[JsonProperty("new")] public string New;

        [JsonProperty("question")]   public string questions;
    
        [JsonProperty("options")]  public string[] options;

        [JsonProperty("rightans")] public string rightAnswer;

    }
}


   
