using UnityEngine.Events;

namespace GeneralComponents
{
    public class FloatExecutor : GameExecutor<float, FloatAction, UnityFloatEvent> { }

    [System.Serializable]
    public class UnityFloatEvent : UnityEvent<float> { }
}
