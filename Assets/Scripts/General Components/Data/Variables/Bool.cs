using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Bool Variable", menuName = GPUtility.VARIABLES_PATH + "Bool", order = 0)]
    public class Bool : Variable<bool> { }
}