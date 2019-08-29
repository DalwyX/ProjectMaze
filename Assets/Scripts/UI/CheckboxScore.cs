using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GeneralComponents;

namespace ProjectMaze
{
    public class CheckboxScore : MonoBehaviour
    {
        [SerializeField] private Int activeScore;
        [SerializeField] private Int currentTarget;
        [SerializeField] private Text activeScoreField;
        [SerializeField] private Text targetScoreField;

        public void UpdateScore()
        {
            if (activeScoreField != null && activeScore != null)
            {
                activeScoreField.text = activeScore.value.ToString();
            }

            if (targetScoreField != null && currentTarget != null)
            {
                targetScoreField.text = currentTarget.value.ToString();
            }
        }
    } 
}
