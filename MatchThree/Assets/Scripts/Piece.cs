using UnityEngine;
using System.Collections.Generic;
public enum PieceTypes
{
    Rat = 0,
    Rat1 = 1,
    Rat2 = 2,
    Rat3 = 3,
    Rat4 = 4,
    Rat5 = 5,
    Rat6 = 6
}
public class Piece
{
    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;
    private bool setForDestruction;
    public Piece()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
      //  pieceType = PieceTypes.Rat;
        setForDestruction = false;
    }
    public Piece(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
      //  this.pieceType = PieceTypes.Rat3;
        this.setForDestruction = false;
    }
    public Piece(Vector3 position, Vector2 gridPosition, PieceTypes pieceType)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = pieceType;
        this.setForDestruction = false;
    }
    public void SetForDestruction()
    {
        this.setForDestruction = true;
    }
    public void SetForDestruction(bool value)
    {
        this.setForDestruction = value;
    }
    public void SetPieceType(PieceTypes pieceType)
    {
        this.pieceType = pieceType;
    }
    public void SetGridPosition(Vector2 position)
    {
        this.gridPosition = position;
    }
    public Vector3 GetPosition()
    {
        return position;
    }
    public Vector3 GetGridPosition()
    {
        return gridPosition;
    }
    public PieceTypes GetPieceType()
    {
        return pieceType;
    }
    public bool GetDestruction()
    {
        return setForDestruction;
    }
}
