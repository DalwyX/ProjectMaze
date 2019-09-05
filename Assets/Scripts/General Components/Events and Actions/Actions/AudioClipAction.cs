using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Audio Clip Action", menuName = GPUtility.EVENTS_PATH + "Audio Clip Action", order = 11)]
    public class AudioClipAction : GameAction<AudioClip> { }
}