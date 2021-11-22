using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public LayerMask unwalkableMask;
    public Vector2 gridWorldSize;
    int width, height;
    public float nodeRadius;
    float cellSize;
    Node[,] grid;

    float nodeDiameter;

    public Grid(Vector2 _gridWorldSize, float _cellSize)
    {
        gridWorldSize = _gridWorldSize;
        cellSize = _cellSize;
    }

    private void Start()
    {
        nodeDiameter = nodeRadius * 2;
        width = Mathf.RoundToInt(gridWorldSize.x / nodeDiameter);
        height = Mathf.RoundToInt(gridWorldSize.y / nodeDiameter);
        CreateGrid();
    }

    private void CreateGrid()
    {
        grid = new Node[width, height];
        Vector3 worldBottomLeft = Vector3.right * gridWorldSize.x / 2 - Vector3.up * gridWorldSize.y / 2;
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Vector3 worldPoint = worldBottomLeft + Vector3.right * ()
                //grid[x, y] = new Node()
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(Vector3.zero, new Vector3(gridWorldSize.x, 1, gridWorldSize.y));
    }
    //public Vector2 GetNodePosition()
    //{

    //}
}
