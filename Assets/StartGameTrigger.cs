using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StartGameTrigger : MonoBehaviour

{
    public GameObject panelStart;
    public GameObject panelGameView;

    public void closePanel()
    {
        panelStart.SetActive(false);
        panelGameView.SetActive(true);
    }

}
