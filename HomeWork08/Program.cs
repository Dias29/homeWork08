using System;

namespace HomeWork08
{
    class Program
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Введите размер массива: ");
            bool isParsed = int.TryParse(Console.ReadLine(), out size);
            if (!isParsed)
            {
                Console.WriteLine("Ошибка!");
            }
            else
            {
                JustArray array = new JustArray(size);
                //Console.WriteLine("\n");

                for (int i = 0; i < size; i++)
                {
                    array[i] = i;
                    Console.WriteLine(i + " = " + array[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
