using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESULT : SCENEMANAGER
{
    SCENEMANAGER sc = new SCENEMANAGER();
    

    public GameObject congrats;
    public GameObject tryagain;

    // Start is called before the first frame update
    void Start()
    {
        if (sc.correctanswers == 1)
        {
            congrats.SetActive(true);

        }
        if (sc.correctanswers == 0)
        {
            tryagain.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
