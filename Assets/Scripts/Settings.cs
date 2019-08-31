using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GeneralComponents;

public class Settings : MonoBehaviour
{
    [SerializeField] private Slider soundSlider;
    [SerializeField] private Slider SFXSlider;
    [SerializeField] private GameEvent volumeChanged;
    private float lastSound = 1f;
    private float lastSFX = 1f;

    private void Awake()
    {
        soundSlider.value = PlayerPrefs.GetFloat("SOUND", 1f);
        SFXSlider.value = PlayerPrefs.GetFloat("SFX", 1f);
    }

    void Update()
    {
        if (soundSlider.value != lastSound)
        {
            PlayerPrefs.SetFloat("SOUND", soundSlider.value);
            volumeChanged?.Notify();
        }
        if (SFXSlider.value != lastSFX)
        {
            PlayerPrefs.SetFloat("SFX", SFXSlider.value);
            volumeChanged?.Notify();
        }
    }
}
