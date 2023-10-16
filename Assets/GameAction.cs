using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameAction : MonoBehaviour
{
    int count = 0;
    public QuestList questList;
    public string selected;

    public TextMeshProUGUI question;
    public Button ansA;
    public Button ansB;
    public Button ansC;
    public Button ansD;

    string corrAns = "";


    int counterText = 0;


     void Start()
    {
        ShowText();
    }
    public void ShowText()
    {

            if (counterText < 5)
            { 
                question.text = ""+questList.listQuestion[counterText].question;
                ansA.GetComponentInChildren<Text>().text = "" + questList.listQuestion[counterText].letterA;
                ansB.GetComponentInChildren<Text>().text = "" + questList.listQuestion[counterText].letterB;
                ansC.GetComponentInChildren<Text>().text = "" + questList.listQuestion[counterText].letterC;
                ansD.GetComponentInChildren<Text>().text = "" + questList.listQuestion[counterText].letterD;

                corrAns = questList.listQuestion[counterText].correctAns;

             }
    

    }


    public void actionButton()
    {

    if (counterText < 5)
        {
            for (int index = 0; index < questList.listQuestion.Length; index++)
            {
                if (questList.listQuestion[index].correctAns.Equals(selected))
                {
                    count++;
                }
            }
        }
    }
    
}
