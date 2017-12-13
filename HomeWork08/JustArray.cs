using System;

namespace HomeWork08
{
    public class JustArray
    {
        private int[] Array;
        public int this[int index]
        {
            get
            {
                return Array[index];
            }

            set
            {
                Array[index] = (int)Math.Pow(value, 2);
            }
        } 

        public JustArray(int size)
        {
            Array = new int[size];
        }
    }
}
