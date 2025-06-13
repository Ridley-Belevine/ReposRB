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

        var WhiteKnightPosition = Console.ReadLine();

        Console.WriteLine("Введите позицию черной ладьи");

        var BlackRookPosition = Console.ReadLine();

        if (WhiteKnightPosition == BlackRookPosition ||
            IsKnightStrike(WhiteKnightPosition, BlackRookPosition))
        {
            Console.WriteLine("Черная ладья не может стоять на этой клетке");

            Console.ReadKey();
            return;
        }

        Console.WriteLine("Введите ход белого коня");
        var Move = Console.ReadLine();

        if (KnightNextMove(Move, WhiteKnightPosition, BlackRookPosition))
            Console.WriteLine("Можно ходить");
        else
            Console.WriteLine("Нельзя ходить");

        Console.ReadKey();
    }
    static bool KnightNextMove(string Move, string WhiteKnightPosition, string BlackRookPosition)
    {
        return IsKnightMoveCorrect(Move, WhiteKnightPosition) &&
               !IsRookToAttackAfter(Move, WhiteKnightPosition, BlackRookPosition);
    }
    static bool IsKnightMoveCorrect(string move, string WhiteKnightPosition)
    {
        int bc, br, mc, mr;

        DecodePosition(WhiteKnightPosition, out bc, out br);
        DecodePosition(move, out mc, out mr);

        return Math.Abs(mc - bc) == Math.Abs(mr - br);
    }

    static bool IsKnightStrike(string WhiteKnightPosition, string BlackRookPosition)
    {
        int bc, br, kc, kr;

        DecodePosition(WhiteKnightPosition, out bc, out br);
        DecodePosition(BlackRookPosition, out kc, out kr);

        return Math.Abs(kc - bc) == Math.Abs(kr - br);
    }

    static bool IsRookToAttackAfter(string Move, string WhiteKnightPosition, string BlackRookPosition)
    {
        int bc, br, kc, kr, mc, mr;

        DecodePosition(WhiteKnightPosition, out bc, out br);
        DecodePosition(BlackRookPosition, out kc, out kr);
        DecodePosition(Move, out mc, out mr);

        return (Math.Abs(kc - mc) == 1 && Math.Abs(kr - mr) == 2) ||
               (Math.Abs(kc - mc) == 2 && Math.Abs(kr - mr) == 1);
    }

    static void DecodePosition(string position, out int column, out int row)
    {
        row = int.Parse(position[1].ToString());
        column = (int)position[0] - 0x60;

    }


}