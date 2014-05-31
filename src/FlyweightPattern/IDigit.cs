using System;

namespace CGeers.Sudoku
{
    public interface IDigit
    {
        Guid Id { get; }
        int Value { get; set; }
        string Display(GridContext gridContext);
    }
}