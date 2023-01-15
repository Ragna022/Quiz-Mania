using Newtonsoft.Json;
using System.Collections.Generic;
using UnityEngine;

public class QuizJsonStructure : MonoBehaviour
{
    [System.Serializable]
    public class QuestionsList
    {
        [JsonProperty("qhsner8_list")] public Questions[] questionsData;
    }

    [System.Serializable]
    public class Questions
    {   
        //[JsonProperty("new")] public string New;

        [JsonProperty("qhsner8_jadr-quest")]   public string questions;
    
        [JsonProperty("qhsner8_jf4-answ")]  public string[] options;

        [JsonProperty("qhsner8t3-right")] public string rightAnswer;

    }
}


   
