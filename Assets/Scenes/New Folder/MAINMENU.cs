using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MAINMENU : MonoBehaviour
{
    [SerializeField] private int Start;
    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(Start);
    }
}
