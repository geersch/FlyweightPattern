using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace CGeers.Sudoku
{
    public class SudokuGrid
    {
        private Collection<Cell> cells = new Collection<Cell>();
        private GridContext gridContext = new GridContext();

        public ICollection<Cell> Cells
        {
            get { return cells; }
        }

        /// <summary>
        /// Constructor for the SudokuGrid class.
        /// Generate 81 cells for the grid filled with random digits
        /// ranging from 1 to 9.
        /// </summary>
        public SudokuGrid(DigitFactory digitFactory)
        {                        
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    int value = random.Next(1, 10);
                    Cell cell = new Cell(digitFactory[value]);
                    cell.Row = i;
                    cell.Column = j;
                    Cells.Add(cell);                    
                }
            }
        }

        //Display the value for each cell in the grid.
        //Pass the extrinsic state (column &row) to the flyweight object.
        public string Display()
        {
            string result = String.Empty;
            foreach (Cell cell in Cells)
            {
                Digit digit = cell.Digit;
                gridContext.Row = cell.Row;
                gridContext.Column = cell.Column;                
                result += digit.Display(gridContext);
            }
            return result;
        }
    }
}