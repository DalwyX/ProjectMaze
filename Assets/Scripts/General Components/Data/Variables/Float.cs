using UnityEngine;

namespace GeneralComponents
{
    [CreateAssetMenu(fileName = "New Float Variable", menuName = GPUtility.VARIABLES_PATH + "Float", order = 2)]
    public class Float : Variable<float> { } 
}