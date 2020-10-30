using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPanel : MonoBehaviour
{
    
    Animator videoPanel;
    Animator settingsPanel;
    Animator settingsBtn;
    GameObject videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = GameObject.Find("VideoPlayer");
        videoPanel = GameObject.Find("VideoPanel").GetComponent<Animator>();
        settingsPanel = GameObject.Find("SettingsPanel").GetComponent<Animator>();
        settingsBtn = GameObject.Find("SettingsButton").GetComponent<Animator>();

    }

    public void settingsButton()
    {

        if (videoPlayer.activeInHierarchy == true)
            videoPlayer.SetActive(false);
        else videoPlayer.SetActive(true);

        if (videoPanel.GetBool("videopanelout"))
            videoPanel.SetBool("videopanelout", false);
        else videoPanel.SetBool("videopanelout", true);

        if (settingsPanel.GetBool("settings"))
            settingsPanel.SetBool("settings", false);
        else settingsPanel.SetBool("settings", true);

        if (settingsBtn.GetBool("spinsettings"))
            settingsBtn.SetBool("spinsettings", false);
        else settingsBtn.SetBool("spinsettings", true);
    }
}
