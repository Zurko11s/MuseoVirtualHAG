using System;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] AudioSource typewriter;
    [SerializeField] AudioSource button;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public void PlayTypewriter()
    {
        typewriter.Play();
    }

    public void PlayButton()
    {
        button.Play();
    }
}
