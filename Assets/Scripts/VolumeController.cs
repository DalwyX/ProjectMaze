using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeController : MonoBehaviour
{
    private AudioSource audioSource;
    [SerializeField] private string volStr;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs.GetFloat(volStr, 1f);
    }

    public void ChangeVolume()
    {
        audioSource.volume = PlayerPrefs.GetFloat(volStr, 1f);
    }
}
