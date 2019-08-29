using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class Progression : MonoBehaviour
    {
        [SerializeField] private List<int> targets = new List<int>();
        [SerializeField] private Int currentScore;
        [SerializeField] private Int currentTarget;

        private void Start()
        {
            currentScore.value = 0;
            currentTarget.value = targets[0];
        }

        public void AddPoint()
        {
            Debug.Log("хай");
            if (currentScore != null && currentTarget != null)
            {
                currentScore.value++;
                if (currentScore.value == currentTarget.value && targets.Count > 0)
                {
                    targets.RemoveAt(0);
                    currentTarget.value = targets[0];
                }
            }
        }
    } 
}
