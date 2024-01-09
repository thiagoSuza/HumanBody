using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
   [SerializeField]
    private VideoPlayer player;
   [SerializeField]
    private VideoClip[] clip;

    [SerializeField]
    private AudioSource aud;
    [SerializeField]
    private Slider _volume;

    [SerializeField]
    private RawImage _image;
    [SerializeField]
    private RenderTexture rt;


   

    private void Start()
    {
        player.SetTargetAudioSource(0, aud);
    }

    public void PlayVideo()
    {        
        player.Play();
        _image.texture = rt;
    }

    public void StopVideo()
    {
        player.Stop();
    }

    public void SetClipIndex(int aux)
    {
        player.clip = clip[aux];
        

    }

    public void Close()
    {
        _image.texture = null;
        StopVideo();
        gameObject.SetActive(false);
    }

   public void SetVolume()
    {
        aud.volume = _volume.value;
    }

}
