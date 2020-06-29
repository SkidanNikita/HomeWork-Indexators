using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork___Indexator_s
{
    public class Indexat_Quad
    {
        private int[] number = new int[100];
        public int this[int index]
        {
            get
            {
                return number[index];
            }
            set
            {
                number[index] = value * value;
            }
        }
    }
}
