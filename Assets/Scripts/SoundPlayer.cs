using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    public class SoundPlayer : MonoBehaviour
    {
        AudioSource audioSource;

        private void Awake()
        {
            audioSource = GetComponent<AudioSource>();
        }

        public void PlaySound(AudioClip clip)
        {
            //AudioSource.P(clip, Camera.main.transform.position);
            audioSource.PlayOneShot(clip);
        }
    } 
}
