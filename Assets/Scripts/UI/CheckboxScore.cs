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
        private Image fillImage;

        private void Awake()
        {
            fillImage = GetComponent<Image>();
        }

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

            if (fillImage != null && activeScore != null && currentTarget != null)
            {
                float p = activeScore.value / currentTarget.value;
                fillImage.fillAmount = p;
            }
        }
    } 
}
