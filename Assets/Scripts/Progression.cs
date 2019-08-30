using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class Progression : MonoBehaviour
    {
        [SerializeField] private List<Reward> targets = new List<Reward>();
        [SerializeField] private Int currentScore;
        [SerializeField] private Int currentTarget;

        [System.Serializable]
        public class Reward
        {
            public string name;
            public int targetScore;
            public GameEvent unlockEvent;
        }

        private void Start()
        {
            currentScore.value = 0;
            currentTarget.value = targets[0].targetScore;
            Time.timeScale = 1;
        }

        public void AddPoint()
        {
            if (currentScore != null && currentTarget != null)
            {
                currentScore.value++;
                if (currentScore.value == currentTarget.value && targets.Count > 0)
                {
                    GameEvent e = targets[0].unlockEvent;
                    targets.RemoveAt(0);
                    if (targets.Count > 0)
                        currentTarget.value = targets[0].targetScore;
                    e?.Notify();
                }
            }
        }
    } 
}
