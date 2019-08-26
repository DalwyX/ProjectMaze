using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class PillarController : MonoBehaviour
    {
        [SerializeField] private GameObject pillarPrefab;
        [SerializeField] private V3 mazeSize;
        [SerializeField] private V3 mazeOrigin;
        [SerializeField] private Float cellSize;

        private void Start()
        {
            SpawnPillars();
        }

        private void SpawnPillars()
        {
            if (pillarPrefab == null)
            {
                Debug.LogError("Отсутсвует префаб Pillar");
                return;
            }

            for (int i = 0; i <= mazeSize.value.x; i++)
            {
                for (int k = 0; k <= mazeSize.value.y; k++)
                {
                    Vector3 pos = mazeOrigin.value + new Vector3(i, 0, k) * cellSize.value;
                    Instantiate(pillarPrefab, pos, Quaternion.identity, transform);
                }
            }

        }
    } 
}
