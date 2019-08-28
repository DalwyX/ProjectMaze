using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    public class GroundCheckbox : MonoBehaviour
    {
        Material mat;
        private bool isActive;

        private void OnCollisionEnter(Collision collision)
        {
            if (isActive)
            {
                FadeIn();
            }
            else
            {
                ActivateAllChildrens();
                isActive = true;
            }
        }

        private void OnCollisionExit(Collision collision)
        {
            FadeOut();
        }

        private void ActivateAllChildrens()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            mat = GetComponentInChildren<MeshRenderer>().material;
        }
        private void FadeIn()
        {
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
