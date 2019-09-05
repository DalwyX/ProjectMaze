using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Vector3 Variable", menuName = GPUtility.VARIABLES_PATH + "Vector3", order = 4)]
    public class V3 : Variable<Vector3> { }
}