using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectMaze
{
    public class Maze
    {
        // TRUE - there is no wall
        // FALSE - there is a wall
        public bool[,] missingHorWalls { get; private set; }
        public bool[,] missingVerWalls { get; private set; }
        private int h;
        private int v;
        private bool[,] visitedCells;

        //public Maze(Vector3 mazeSize, Vector2 initialCell)
        public Maze(Vector3 mazeSize)
        {
            h = (int)mazeSize.x;
            v = (int)mazeSize.y;
            missingHorWalls = new bool[h, v + 1];
            missingVerWalls = new bool[h + 1, v];
            visitedCells = new bool[h, v];
            //Generate(initialCell);
            Generate();
        }

        //private void Generate(Vector2 startPos)
        private void Generate()
        {
            Vector2Int activeCell = new Vector2Int(0, 0);
            //activeCell.x = (int)startPos.x;
            //activeCell.y = (int)startPos.y;

            Stack<Vector2Int> pathStack = new Stack<Vector2Int>();
            pathStack.Push(activeCell);

            visitedCells[activeCell.x, activeCell.y] = true;

            while (pathStack.Count > 0)
            {
                Vector2Int neighbour = GetNeighbour(activeCell);
                if (neighbour == activeCell)
                {
                    activeCell = pathStack.Pop();
                    continue;
                }

                RemoveWall(activeCell, neighbour);
                activeCell = neighbour;
                pathStack.Push(neighbour);
                visitedCells[activeCell.x, activeCell.y] = true;
            }

            // отрефакторить
            missingHorWalls[12, 0] = true;
        }

        private Vector2Int GetNeighbour(Vector2Int cell)
        {
            List<Vector2Int> neighbours = new List<Vector2Int>();
            if (cell.x > 0 && !visitedCells[cell.x - 1, cell.y])
            {
                neighbours.Add(new Vector2Int(cell.x - 1, cell.y));
            }
            if (cell.x < h - 1 && !visitedCells[cell.x + 1, cell.y])
            {
                neighbours.Add(new Vector2Int(cell.x + 1, cell.y));
            }
            if (cell.y > 0 && !visitedCells[cell.x, cell.y - 1])
            {
                neighbours.Add(new Vector2Int(cell.x, cell.y - 1));
            }
            if (cell.y < v - 1 && !visitedCells[cell.x, cell.y + 1])
            {
                neighbours.Add(new Vector2Int(cell.x, cell.y + 1));
            }

            if (neighbours.Count == 0) return cell;

            int i = Random.Range(0, neighbours.Count);
            return neighbours[i];
        }

        private void RemoveWall(Vector2Int cell1, Vector2Int cell2)
        {
            Vector2Int diff = cell2 - cell1;

            if (diff == Vector2Int.left)
            {
                missingVerWalls[cell1.x, cell1.y] = true;
            }
            else if (diff == Vector2Int.right)
            {
                missingVerWalls[cell1.x + 1, cell1.y] = true;
            }
            else if (diff == Vector2Int.up)
            {
                missingHorWalls[cell1.x, cell1.y + 1] = true;
            }
            else if (diff == Vector2Int.down)
            {
                missingHorWalls[cell1.x, cell1.y] = true;
            }
        }
    }
}
