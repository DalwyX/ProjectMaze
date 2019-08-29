using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class GroundCheckbox : MonoBehaviour
    {
        [SerializeField] private GameEvent checkboxActivated;
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
            Destroy(transform.GetChild(0).gameObject);
            Destroy(GetComponent<Collider>());
            gameObject.AddComponent<BoxCollider>();
            for (int i = 0; i < transform.childCount; i++)
            {
                transform.GetChild(i).gameObject.SetActive(true);
            }
            mat = transform.GetChild(1).GetComponent<MeshRenderer>().material;
            checkboxActivated?.Action();
            FadeOut();
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
