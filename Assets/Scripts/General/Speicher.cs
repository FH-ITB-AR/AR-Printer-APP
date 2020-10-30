using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speicher : MonoBehaviour
{
    public void StartAbfrageEnde()
    {
        PlayerPrefs.SetInt("startabfrage", 1);
        PlayerPrefs.Save();
    }

    public void Togglebestellung()
    {
        PlayerPrefs.SetInt("MeldungBestellung", 1);
        PlayerPrefs.Save();
    }

    public void ARalsStandard()
    {
        PlayerPrefs.SetInt("Standardansicht", 1);
        PlayerPrefs.Save();
    }

    public void VRalsStandard()
    {
        PlayerPrefs.SetInt("Standardansicht", 2);
        PlayerPrefs.Save();
    }
}
