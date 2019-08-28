using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    public class GroundCheckbox : MonoBehaviour
    {
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
        }
        private void FadeIn()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                MeshRenderer mr = transform.GetChild(i).GetComponent<MeshRenderer>();
                if (mr == null) continue;
                Color c = mr.material.GetColor("_EmissionColor") * 1.25f;
                mr.material.SetColor("_EmissionColor", c);
            }
        }

        private void FadeOut()
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                MeshRenderer mr = transform.GetChild(i).GetComponent<MeshRenderer>();
                if (mr == null) continue;
                Color c = mr.material.GetColor("_EmissionColor") * 0.8f;
                mr.material.SetColor("_EmissionColor", c);
            }
        }
    }
}
