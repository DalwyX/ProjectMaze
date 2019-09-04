using UnityEngine;
using UnityEngine.Events;

namespace GeneralComponents
{
    public class V3Executor : GameExecutor<Vector3, V3Action, UnityV3Event> { }

    [System.Serializable]
    public class UnityV3Event : UnityEvent<Vector3> { }
}
