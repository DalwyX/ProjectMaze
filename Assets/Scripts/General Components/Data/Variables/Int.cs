using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Int Variable", menuName = GPUtility.VARIABLES_PATH + "Int", order = 1)]
    public class Int : Variable<int> { } 
}