using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Introdution : MonoBehaviour
{
    // Start is called before the first frame update
    public Image canvasImage;
    public Sprite[] canvasSprite;
    void Start()
    {
        StartCoroutine(StartScene());
    }

    private IEnumerator StartScene()
    {
        for (int i = 0; i < canvasSprite.Length; i++)
        {
            yield return new WaitForSeconds(1);
            canvasImage.sprite = canvasSprite[i];
            yield return new WaitForSeconds(1);
        }
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
