using System;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class AudioManager : MonoBehaviour
{
    public Slider volumeSlider;
    public Audio[] audios;
    public static AudioManager instancia;

    float volumeValue;
    float lastVolumeValue;
    float volSaved;

    private void Awake()
    {
        /*if(instancia == null)
        {
            instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }*/

        volSaved = PlayerPrefs.GetFloat("volumen");

        foreach (Audio a in audios)
        {
            a.source = gameObject.AddComponent<AudioSource>();
            a.source.clip = a.audioFile;
            a.source.volume = a.volume;
            a.source.pitch = a.pitch;
            a.source.loop = a.loop;
        }
    }

    private void Start()
    {
        volumeSlider.value = volSaved;
        volumeValue = volumeSlider.value;
        ChangeVolume();
        Play("Rayos");
        Play("Lluvia");
        Play("Viento");
        
    }

    private void Update()
    {
        volumeValue = volumeSlider.value;

        if (volumeValue != lastVolumeValue)
        {
            ChangeVolume();
            GuardarVol();
        }

        lastVolumeValue = volumeValue;

    }

    public void Play(string name)
    {
        Audio a = Array.Find(audios, audios => audios.name == name);

        if (a == null)
        {
            Debug.LogWarning("El nombre del archivo de audio" + name + "no existe");
            return;
        }
        a.source.Play();
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeValue;
    }

    public void GuardarVol()
    {
        PlayerPrefs.SetFloat("volumen", volumeSlider.value);
        PlayerPrefs.Save();
    }
}