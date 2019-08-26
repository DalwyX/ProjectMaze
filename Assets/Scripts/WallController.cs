using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GeneralComponents;

namespace ProjectMaze
{
    public class WallController : MonoBehaviour
    {
        [SerializeField] private GameObject wallPrefab;
        [SerializeField] private V3 mazeSize;
        [SerializeField] private V3 mazeOrigin;
        [SerializeField] private Float cellSize;

        private int horizontalIndexes;
        private int verticalIndexes;

        private void Start()
        {
            Maze maze = new Maze(mazeSize.value);
            SpawnAllWalls();
            ProcessWalls(maze);
        }

        private void SpawnAllWalls()
        {
            if (wallPrefab == null)
            {
                Debug.LogError("Отсутсвует префаб Wall");
                return;
            }

            horizontalIndexes = 0;
            verticalIndexes = (int) (mazeSize.value.x * (mazeSize.value.y + 1));

            for (int i = 0; i < mazeSize.value.x; i++)
            {
                for (int k = 0; k <= mazeSize.value.y; k++)
                {
                    Vector3 pos = mazeOrigin.value + new Vector3(cellSize.value / 2, 0) + new Vector3(i, 0, k) * cellSize.value;
                    Instantiate(wallPrefab, pos, Quaternion.identity, transform);
                }
            }

            for (int i = 0; i <= mazeSize.value.x; i++)
            {
                for (int k = 0; k < mazeSize.value.y; k++)
                {
                    Vector3 pos = mazeOrigin.value + new Vector3(0, 0, cellSize.value / 2) + new Vector3(i, 0, k) * cellSize.value;
                    Instantiate(wallPrefab, pos, Quaternion.Euler(0, 90, 0), transform);
                }
            }
        }

        private void ProcessWalls(Maze maze)
        {
            for (int i = 0; i < mazeSize.value.x; i++)
            {
                for (int k = 0; k <= mazeSize.value.y; k++)
                {
                    if (!maze.missingHorWalls[i, k]) continue;
                    int n = horizontalIndexes + i * ((int)mazeSize.value.y + 1) + k;
                    transform.GetChild(n).gameObject.SetActive(false);
                }
            }

            for (int i = 0; i <= mazeSize.value.x; i++)
            {
                for (int k = 0; k < mazeSize.value.y; k++)
                {
                    if (!maze.missingVerWalls[i, k]) continue;
                    int n = verticalIndexes + i * (int)mazeSize.value.y + k;
                    transform.GetChild(n).gameObject.SetActive(false);
                }
            }
        }
    } 
}
