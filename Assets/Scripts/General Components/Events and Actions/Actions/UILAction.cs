using UnityEngine.Events;

namespace GeneralComponents
{
    public class UILAction : GameAction<UILayer, UILEvent, UnityUILEvent> { }

    [System.Serializable]
    public class UnityUILEvent : UnityEvent<UILayer> { }
}
