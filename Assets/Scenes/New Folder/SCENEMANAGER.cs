using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SCENEMANAGER : MonoBehaviour
{
    public int correctanswers;
    [SerializeField] private int Scenes;
    public bool isCorrect = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void Correct()
    {
        SceneManager.LoadScene(Scenes);
        Debug.Log("Correct");
        correctanswers++;

    }
    public void Wrong()
    {
        SceneManager.LoadScene(Scenes);
        Debug.Log("Wrong");
    }
}
