using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoSource : MonoBehaviour
{

    public VideoClip videoClip;


    public string videoUrl;

    public string myKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onClick()
    {
        if (videoClip != null)
        {
            GameManager.instance.Play(videoClip);
        }
        else
        {
            GameManager.instance.PlayUrl(videoUrl);
        }

    }

}
