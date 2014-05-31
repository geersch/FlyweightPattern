using System;
using CGeers.Sudoku;

namespace SudokuConsoleApplication
{
    class Program
    {
        //static Digit CreateDigitEight()
        //{
        //    DigitFactory digitFactory = new DigitFactory();
        //    Digit digit = digitFactory[8];
        //    return digit;
        //}

        static void Main()
        {
            DigitFactory digitFactory = new DigitFactory();                        
            SudokuGrid sudokuGrid = new SudokuGrid(digitFactory);            

            Console.WriteLine(sudokuGrid.Display());

            Console.WriteLine("\n\rPress return to exit.\n\r");
            Console.ReadLine();
        }
    }
}
