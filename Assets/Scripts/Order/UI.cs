using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //public Animator fhButton;
    public Animator startabfrage;

    public GameObject eingabeAbfrage;
    public GameObject meldungBestellung;

    private void Start()
    {
        
        if (PlayerPrefs.GetInt("startabfrage") == 1)
        {
            eingabeAbfrage.SetActive(false);
            MenuPositions();
        }

        if (PlayerPrefs.GetInt("MeldungBestellung") == 1)
        {
            meldungBestellung.SetActive(false);
        }


    }

    public void MenuPositions()
    {
        //fhButton.SetBool("menuposition", true);
        startabfrage.SetBool("menuposition", true);
    }


}
