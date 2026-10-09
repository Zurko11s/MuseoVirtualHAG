using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField] AudioSource typewriter;
    [SerializeField] AudioSource button;
    [SerializeField] AudioSource museumMusic;
    [SerializeField] AudioMixer audioMixer;
    [SerializeField] Slider volumeSlider;
    
    [SerializeField] private string exposedParameter = "MasterVolume";


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
    
    public void Start()
    {

		//se define el limite de valores del slider
        volumeSlider.minValue = 0.0001f; // avoid Log10(0)
        volumeSlider.maxValue = 1f;
        
        //se define que valor expuesto del audiomixer se va a cambiar
        float saved = PlayerPrefs.GetFloat(exposedParameter, 1f);
        volumeSlider.value = saved;
        SetVolume(saved);

        volumeSlider.onValueChanged.AddListener(SetVolume);
        
        PlayMuseumMusic();
	}
	
	 public void SetVolume(float value)
    {
		//se convierten los valores del slider a los que usa el mixer
        audioMixer.SetFloat(exposedParameter, Mathf.Log10(value) * 20f);
        PlayerPrefs.SetFloat(exposedParameter, value);
        
        // esto era para probar en consola que funcionara
        //float dB = Mathf.Log10(value) * 20f;
        //bool ok = audioMixer.SetFloat(exposedParameter, dB);
        //Debug.Log($"Slider: {value} -> {dB} dB | SetFloat succeeded: {ok}");
    }

    public void PlayTypewriter()
    {
        typewriter.Play();
    }

    public void PlayButton()
    {
        button.Play();
    }
    
    public void PlayMuseumMusic()
    {
		museumMusic.Play();
	}
	
}
