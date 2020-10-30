using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideButton : MonoBehaviour
{
    public Image imgAnleitung;
    public Image imgBestellen;
    public UnityEngine.UI.Extensions.HorizontalScrollSnap videoplayerHSS;


    private void Start()
    {
        ButtonAusblenden();
    }

    // Start is called before the first frame update
    public void ButtonAusblenden()
    {
        if (videoplayerHSS.CurrentPage == 1)
        {
            imgBestellen.enabled = false;
            imgAnleitung.enabled = true;
        }
        if (videoplayerHSS.CurrentPage == 0)
        {
            imgAnleitung.enabled = false;
            imgBestellen.enabled = true;
        }


        }


    }
