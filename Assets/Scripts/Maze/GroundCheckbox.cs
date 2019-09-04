using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class GroundCheckbox : MonoBehaviour
    {
        [SerializeField] private GameEvent checkboxActivated;
        [SerializeField] private GameEvent checkboxTrigger;
        [SerializeField] private Material checkboxOnMat;
        private MeshRenderer mr;
        private Material mat;
        private bool isActive;

        private void OnCollisionEnter(Collision collision)
        {
            if (isActive)
            {
                FadeIn();
            }
            else
            {
                ActivateCheckbox();
                isActive = true;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            FadeOut();
        }

        private void ActivateCheckbox()
        {
            transform.GetChild(0).gameObject.SetActive(true);
            mr = GetComponent<MeshRenderer>();
            mr.sharedMaterial = checkboxOnMat;
            mat = mr.material;
            checkboxActivated?.Raise();
            FadeOut();
        }
        private void FadeIn()
        {
            checkboxTrigger?.Raise();
            Color c = mat.GetColor("_EmissionColor") * 1.25f;
            mat.SetColor("_EmissionColor", c);
        }

        private void FadeOut()
        {
            Color c = mat.GetColor("_EmissionColor") * 0.8f;
            mat.SetColor("_EmissionColor", c);
        }
    }
}
