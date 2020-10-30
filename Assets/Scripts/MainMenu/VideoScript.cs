using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public UnityEngine.UI.Extensions.HorizontalScrollSnap videoplayerHSS;
    public RawImage[] rawImage;
    public VideoPlayer[] videoPlayer;

    int i = 0;

    // Use this for initialization
    void Start()
    {
        int i = videoplayerHSS.CurrentPage;
        StartCoroutine(PlayVideo());
    }

    IEnumerator PlayVideo()
    {
        int i = videoplayerHSS.CurrentPage;

        videoPlayer[i].Prepare();
        WaitForSeconds waitForSeconds = new WaitForSeconds(0.5f);
        while (!videoPlayer[i].isPrepared)
        {
            yield return waitForSeconds;
            break;
        }
        rawImage[i].texture = videoPlayer[i].texture;
        videoPlayer[i].Play();
    }

    public void PageChange()
    {
        videoPlayer[0].Stop();
        videoPlayer[1].Stop();
        StartCoroutine(PlayVideo());
    }
    
}
