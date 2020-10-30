using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour {


    

    public void Warenkorb()
    {
        SceneManager.LoadScene("Warenkorb");
    }
    
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }

    public void Bestellen_Modell()
    {
        SceneManager.LoadScene("AR_Bestellung");
    }

    public void Hauptmenue()
    {
        SceneManager.LoadScene("Hauptmenü");
    }

    public void ARAnleitung()
    {
        SceneManager.LoadScene("AR_Anleitung");
    }
    
    




    /*
    public void GoToDrucker_sfs_toner()
    {
        SceneManager.LoadScene("drucker_sfs_toner");
    }

    public void GoToDrucker_sfs_papierrein()
    {
        SceneManager.LoadScene("drucker_sfs_papierrein");
    }

    public void GoToDrucker_sfs_papierstau()
    {
        SceneManager.LoadScene("drucker_sfs_papierstau");
    }
    public void GoToMovements()
    {
        SceneManager.LoadScene("movements");
    }

    public void GoToValveService()
    {
        SceneManager.LoadScene("valve_service");
    }

    public void GoToExplosion()
    {
        SceneManager.LoadScene("explosion");
    }

    // Virtual Twin Go..

    public void GoToVTwin_arcam()
    {
        SceneManager.LoadScene("vtwin_arcam");
    }

    */

    public void ExitApplication()
    {
        Application.Quit();
    }
}
