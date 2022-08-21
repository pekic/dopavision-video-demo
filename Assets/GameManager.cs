using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    public VideoPlayer videoPlayer;

    public Canvas canvas;

    public GameObject video;

    public VideoSource left;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        Invoke("StartLeftVideo", 3);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetAxis("Vertical") != 0)
        {
            Camera.main.transform.Translate(0, 0, Input.GetAxis("Vertical") * Time.deltaTime * 100);
        }

    }

    public void StartLeftVideo()
    {
        left.onClick();
    }

    public void PlayUrl(string videoUrl)
    {

        HideCanvas();

        ShowVideo();

        videoPlayer.source = UnityEngine.Video.VideoSource.Url;
        videoPlayer.url = videoUrl;
        videoPlayer.EnableAudioTrack(0, true);
        videoPlayer.Prepare();
        //videoPlayer.Play();

        Invoke("StartVideo", 2);

    }

    public void StartVideo()
    {
        videoPlayer.Play();
    }

    public void Play(VideoClip videoClip)
    {
        HideCanvas();

        ShowVideo();

        videoPlayer.source = UnityEngine.Video.VideoSource.VideoClip;
        videoPlayer.clip = videoClip;
        videoPlayer.Play();


    }

    public void ShowVideo()
    {
        video.SetActive(true);
    }

    public void HideVideo()
    {
        video.SetActive(false);
    }

    public void ShowCanvas()
    {
        canvas.gameObject.SetActive(true);
    }

    public void HideCanvas()
    {
        canvas.gameObject.SetActive(false);
    }
}
