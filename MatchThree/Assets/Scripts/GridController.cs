using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour
{

    [SerializeField]
    private GameObject piecePrefab;

    [SerializeField]
    private Vector3 originPosition;

    private Piece[,] grid = new Piece[8, 8];
    void Start()
    {

        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                Vector3 newWorldPosition = new Vector3(originPosition.x + row, originPosition.y, originPosition.z - column);
                grid[row, column] = new Piece(newWorldPosition, new Vector2(row, column));

                Instantiate(piecePrefab, grid[row, column].GetPosition(), Quaternion.identity);
            }
        }
    }

    void Update()
    {

    }
}