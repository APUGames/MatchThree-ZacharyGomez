using System;
using UnityEngine;

public class GridController : MonoBehaviour
{
    [SerializeField]
    private GameObject piecePrefab;
    [SerializeField]
    private Vector3 originPosition;

    [Header("Piece Colors")]
    [SerializeField]
    private Material pieceOneMaterial;
    [SerializeField]
    private Material pieceSecondMaterial;
    [SerializeField]
    private Material pieceThirdMaterial;
    [SerializeField]
    private Material pieceFourMaterial;
    [SerializeField]
    private Material pieceFiveMaterial;
    [SerializeField]
    private Material pieceSixMaterial;
    private Piece[,] grid = new Piece[8, 8];
    void Start()
    {
        System.Random rand = new System.Random();

        for (int row = 0; row < grid.GetLength(0); row++)
        {
            for (int column = 0; column < grid.GetLength(1); column++)
            {
                Vector3 newWorldPosition = new Vector3(originPosition.x + row, originPosition.y, originPosition.z - column);
                grid[row, column] = new Piece(newWorldPosition, new Vector2(row, column));

                GameObject gameObject = Instantiate(piecePrefab, grid[row, column].GetPosition(), Quaternion.identity);
                int theNumber = rand.Next(13, 101);
                if (theNumber > 30 && theNumber < 45)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();
                    gameObjectRenderer.material = pieceOneMaterial;
                }
                else if (theNumber >= 45 && theNumber < 60)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();
                    gameObjectRenderer.material = pieceFourMaterial;
                }
                else if (theNumber >= 60 && theNumber < 85)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();

                    gameObjectRenderer.material = pieceSecondMaterial;
                }
                else if (theNumber >= 85 && theNumber < 101)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();
                    gameObjectRenderer.material = pieceThirdMaterial;
                }
                else if (theNumber >= 10 && theNumber < 30)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();
                    gameObjectRenderer.material = pieceSixMaterial;
                }
                else if (theNumber >= 101 && theNumber < 130)
                {
                    var gameObjectRenderer = gameObject.GetComponent<Renderer>();
                    gameObjectRenderer.material = pieceFiveMaterial;
                }
            }
        }
    }
    void Update()
    {

    }
}