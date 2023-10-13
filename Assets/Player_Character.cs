using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player_Character : MonoBehaviour
{
    public Animator transition;
    public Button nextSlideButton;
    public Image headImage;
    public Image hairImage;
    public Sprite[] headSprite;
    public Sprite[] hairSprite;
    public GameObject[] canvas, bodyCanvas;
    public Button[] headButton, hairButton;

    private int headValue, hairValue;
    void Start()
    {
        for (int i = 0; i < headButton.Length; i++)
        {
            int headIndex = i;
            headButton[i].onClick.AddListener(() => SetHeadValue(headIndex));
        }

        for (int j = 0; j < hairButton.Length; j++)
        {
            int hairIndex = j;
            hairButton[j].onClick.AddListener(() => SetHairValue(hairIndex));
        }

        nextSlideButton.onClick.AddListener(StartSlide);
        nextSlideButton.gameObject.SetActive(true);
    }
    public void SetHeadValue(int headIndex)
    {
        Debug.Log(headValue);
        headValue = headIndex;
        headImage.gameObject.SetActive(true);
        headImage.sprite = headSprite[headValue];
        nextSlideButton.onClick.AddListener(HeadDone);
        nextSlideButton.gameObject.SetActive(true);
    }
    public void SetHairValue(int hairIndex)
    {
        hairValue = hairIndex;
        hairImage.gameObject.SetActive(true);
        hairImage.sprite = hairSprite[hairValue];
        nextSlideButton.onClick.AddListener(HairDone);
        nextSlideButton.gameObject.SetActive(true);
    }
    private void StartSlide()
    {
        StartCoroutine(StartSceneCoroutine());
    }

    private  IEnumerator StartSceneCoroutine()
    {
        nextSlideButton.gameObject.SetActive(false);
        nextSlideButton.onClick.RemoveAllListeners();
        nextSlideButton.onClick.AddListener(StartSlide);
        Debug.Log("StartScene");
        yield return new WaitForSeconds(1);
        transition.Play("Transition");
        yield return new WaitForSeconds(2);
        canvas[0].SetActive(true);
        transition.Play("Transition_Fade");
    }


    public void HeadDone()
    {
        StartCoroutine(HeadDoneCoroutine());
    }

    private IEnumerator HeadDoneCoroutine()
    {
        nextSlideButton.gameObject.SetActive(false);
        transition.Play("Transition");
        yield return new WaitForSeconds(2);
        canvas[0].SetActive(false);
        canvas[1].SetActive(true);
        transition.Play("Transition_Fade");
        bodyCanvas[0].SetActive(false);
        bodyCanvas[1].SetActive(false);
    }
    public void HairDone()
    {
        StartCoroutine(HairDoneCoroutine());
    }

    private IEnumerator HairDoneCoroutine()
    {
        nextSlideButton.gameObject.SetActive(false);
        transition.Play("Transition");
        yield return new WaitForSeconds(2);
        canvas[0].SetActive(false);
        canvas[1].SetActive(false);
        transition.Play("Transition_Fade");
        yield return new WaitForSeconds(7);
        nextSlideButton.onClick.RemoveAllListeners();
        nextSlideButton.onClick.AddListener(LoadScene);
        nextSlideButton.gameObject.SetActive(true);
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(0);
    }
}
