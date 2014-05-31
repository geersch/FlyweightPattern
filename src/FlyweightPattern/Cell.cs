using System;

namespace CGeers.Sudoku
{
    public class Cell
    {                
        public Digit Digit { get ; private set; }        

        public int Row { get; set; }

        public int Column { get; set; }        

        public Cell(Digit digit)
        {
            Digit = digit;
        }
    }
}