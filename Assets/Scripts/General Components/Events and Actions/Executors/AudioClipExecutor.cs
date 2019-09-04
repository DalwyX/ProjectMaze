using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public class AudioClipExecutor : GameExecutor<AudioClip, AudioClipAction, UnityAudioClipEvent> { }

    [System.Serializable]
    public class UnityAudioClipEvent : UnityEvent<AudioClip> { }
}
