using System;
using System.Collections.Generic;

namespace CGeers.Sudoku
{
    public class DigitFactory
    {
        private Dictionary<int, Digit> arrDigits = new Dictionary<int, Digit>();

        public Digit this[int key]
        {
            get
            {
                if (arrDigits.ContainsKey(key))
                {
                    return arrDigits[key];
                }
                else
                {
                    arrDigits.Add(key, new Digit());
                    arrDigits[key].Value = key;
                    return arrDigits[key];
                }
            }
            set { arrDigits[key] = value; }
        }
    }
}