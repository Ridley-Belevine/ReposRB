using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите позицию белого коня");

        var whiteKnightPosition = Console.ReadLine();
        int whiteKnightRow, whiteKnightColumn;
        DecodePosition(whiteKnightPosition, out whiteKnightRow, out whiteKnightColumn);

        Console.WriteLine("Теперь, введите позицию черной ладьи");

        var blackRookPosition = Console.ReadLine();
        int blackRookRow, blackRookColumn;
        DecodePosition(blackRookPosition, out blackRookRow, out blackRookColumn);

        if (whiteKnightRow == blackRookRow && whiteKnightColumn == blackRookColumn)
        {
            Console.WriteLine("Данная фигура не может здесь находиться, посколько это место занято другой");
            return;
        }

        Console.WriteLine("Введите клетку, на которую будет совершен ход белой фигуры");
        var moveSide = Console.ReadLine();
        int moveRow, moveColumn;
        DecodePosition(moveSide, out moveRow, out moveColumn);

        if (CanWhiteFigureMove(whiteKnightRow, whiteKnightColumn, moveRow, moveColumn) &&
               !IfUnderAttackByBlackFigure(moveRow, moveColumn, blackRookRow, blackRookColumn))
        {
            Console.WriteLine("Ход разрешен: дальнешие ходы возможны и ладья не препятствует пути");
        }
        else
        {
            Console.WriteLine("Ход запрещен: дальнешие ходы невозможны или ладья препятствует пути");
        }

        Console.ReadKey();
    }
    static void DecodePosition(string side, out int row, out int column)
    {
        row = int.Parse(side[1].ToString());
        column = side[0] - 'a' + 1;
    }

    static bool CanWhiteFigureMove(int whiteFigureRow, int whiteFigureColumn, int moveRow, int moveColumn)
    {
        return (Math.Abs(moveRow - whiteFigureRow) == 2 && Math.Abs(moveColumn - whiteFigureColumn) == 1) ||
            (Math.Abs(moveRow - whiteFigureRow) == 1 && Math.Abs(moveColumn - whiteFigureColumn) == 2);
    }

    static bool IfUnderAttackByBlackFigure(int blackFigureRow, int blackFigureColumn, int moveRow, int moveColumn)
    {
        return blackFigureRow == moveRow || blackFigureColumn == moveColumn;
    }
}