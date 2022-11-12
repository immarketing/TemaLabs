using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaLabs
{
    internal class Lab5
    {
        public static void doWork()
        {
            System.Console.WriteLine("Doing something");
            Start();
        }

        static void printarr2(int[,] field)
        {
            for (int i = 0; i < field.GetLength(0); i++)
            {
                for (int j = 0; j < field.GetLength(1); j++)
                {
                    Console.Write("| " + field[i, j] + "\t");

                }
                Console.WriteLine("|");
            }
        }





        //ОСНОВНОЙ МЕТОД ДЛЯ ИГРЫ В МОРСКОЙ БОЙ
        public static void Start()
        {
            Console.WriteLine("I'm a seabattle game");

            int[,] field = new int[10, 10];

            printarr2(field);

            int[,] fieldfp = new int[10, 10]; //field for player

        }
    }
}
