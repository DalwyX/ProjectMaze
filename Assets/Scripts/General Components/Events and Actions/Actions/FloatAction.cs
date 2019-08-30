using UnityEngine.Events;

namespace GeneralComponents
{
    public class FloatAction : GameAction<float, FloatEvent, UnityFloatEvent> { }

    [System.Serializable]
    public class UnityFloatEvent : UnityEvent<float> { }
}
