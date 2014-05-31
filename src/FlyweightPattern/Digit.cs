using System;

namespace CGeers.Sudoku
{
    public class Digit : IDigit
    {        
        #region Constructor

        public Digit()
        {             
            Id = Guid.NewGuid();                 
        }

        #endregion

        #region IDigit Members

        /// <summary>
        /// Intrisic state
        /// </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Intrisic state
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Intrisic state + act upon extrinsic state
        /// </summary>
        /// <param name="gridContext"></param>
        /// <returns></returns>
        public string Display(GridContext gridContext)
        {
            return String.Format("Digit {0}, Id: {1}, " + 
                "Column: {2}, Row: {3}", Value, Id, gridContext.Column, 
                gridContext.Row) + "\n\r";                        
        }

        #endregion
    }
}