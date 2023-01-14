using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;




namespace JsonFromFileApp
{ 

public class QuizmaniaData : MonoBehaviour
{

    /*public class QuizmaniaData
    {
        public string questions;
        public string options;

    }

    public Questions[] QuetionsDataSet;*/
    static void Main(string[] args)
    {
        var path = @"Assets / UnityProjectFiles / quiz.json";
        string jsonFile = File.ReadAllText(path);

            Quiz q = JsonConvert.DeserializeObject<Quiz>(jsonFile);

            foreach (var item in q.Options)
            {
                Console.WriteLine($"Options: {item}");
            }

            //Console.WriteLine(q.Question);
            Console.WriteLine($"Options: {q.Options}");
            Console.WriteLine($"Rightans: {q.Rightans}");
    }


        public class Quiz
        {

            public string Question { get; set; }
            public string[] Options { get; set; }
            public string Rightans { get; set; }
        }

        /*public static QuizmaniaData Instance;
   private void Awake()
    {

        if (Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
        }
        else
        {
            Destroy(this);
        }*/
    }
        
    
    
    
  
}
