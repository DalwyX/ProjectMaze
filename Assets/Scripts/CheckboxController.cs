using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class CheckboxController : MonoBehaviour
    {
        [SerializeField] private GameObject checkboxPrefab;
        [SerializeField] private V3 mazeSize;
        [SerializeField] private V3 mazeOrigin;
        [SerializeField] private Float cellSize;

        private void Start()
        {
            SpawnCheckboxes();
        }

        private void SpawnCheckboxes()
        {
            if (checkboxPrefab == null) return;
            for (int i = 0; i < mazeSize.value.x; i++)
            {
                for (int k = 0; k < mazeSize.value.y; k++)
                {
                    Vector3 pos = mazeOrigin.value + new Vector3(cellSize.value / 2, 0, cellSize.value / 2) + new Vector3(i * cellSize.value, 0, k * cellSize.value);
                    Instantiate(checkboxPrefab, pos, Quaternion.identity, transform);
                }
            }
        }
    }
}
