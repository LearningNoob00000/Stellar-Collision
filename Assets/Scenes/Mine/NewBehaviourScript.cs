using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI text;
    public string[] textnew;
    public Button[] value;
    public int[] scores = { 1, 2, 3, 5 };
    public int currentAnswer;
    public int level;
    void Start()
    {
        for (int i = 0; i < value.Length; i++) {
            int index = i;
            value[index].onClick.AddListener(()=> SetValue(index));
        }
    }

    public void SetValue(int index)
    {
        currentAnswer = index;
        Checlk();
        
    }


    public void Checlk()
    {
        if(currentAnswer == scores[level]) 
        {
        
        }
        //text.text = textnew;
    }





    // Update is called once per frame
    void Update()
    {
        
    }
}
