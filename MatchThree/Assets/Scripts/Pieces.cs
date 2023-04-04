using UnityEngine;

public enum PieceTypes
{
    FatRat = 0,
    JermaRat = 1,
    Remy = 2,
    SquishyRat = 3,
    BiggieCheese = 4,
    Halo3Rat = 5,
}

public class Piece
{
    private Vector3 position;
    private Vector2 gridPosition;
    private PieceTypes pieceType;

    public Piece()
    {
        position = Vector3.zero;
        gridPosition = Vector2.zero;
        pieceType = PieceTypes.JermaRat;
    }
    public Piece(Vector3 position, Vector2 gridPosition)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = PieceTypes.SquishyRat;
    }
    public Piece(Vector3 position, Vector2 gridPosition, PieceTypes pieceType)
    {
        this.position = position;
        this.gridPosition = gridPosition;
        this.pieceType = pieceType;
    }
    public Vector3 GetPosition()
    {
        return position;
    }
    public PieceTypes GetPieceType()
    {
        return pieceType;
    }
}