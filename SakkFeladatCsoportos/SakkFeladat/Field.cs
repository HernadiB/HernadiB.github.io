using System;

namespace SakkFeladat
{
    public class Field
    {
        public int X;
        public int Y;
        public Piece piece;
        public Field(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw()
        {
            if(piece != null){
                if (piece.PieceColor == Color.white){
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else{
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                switch (piece.PieceType)
                {
                    case PieceType.rook:
                        {
                            Console.Write(" R "); 
                            break;
                        }
                    case PieceType.king:
                        {
                            Console.Write(" KI "); 
                            break;
                        }
                    case PieceType.knight:
                        {
                            Console.Write(" KN "); 
                            break;
                        }
                    case PieceType.pawn:
                        {
                            Console.Write(" P "); 
                            break;
                        }
                    case PieceType.queen:
                        {
                            Console.Write(" Q "); 
                            break;
                        }
                    case PieceType.bishop:
                        {
                            Console.Write(" B "); 
                            break;
                        }
                    default:
                        {
                            Console.Write("   "); 
                            break;
                        }
                }
            }
            else{
                Console.Write("   ");
            }
        }
    }
}
