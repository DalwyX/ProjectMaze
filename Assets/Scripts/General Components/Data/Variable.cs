using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GeneralComponents
{
    public class Variable<T> : ScriptableObject
    {
        [SerializeField] private T val;
        [SerializeField] private bool readOnly = false;

        public T value
        {
            get
            {
                return val;
            }
            set
            {
                if (readOnly)
                {
                    Debug.Log("Попытка изменения readonly переменной!");
                    return;
                }
                val = value;
            }
        }
    }
}
