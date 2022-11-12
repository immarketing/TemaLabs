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
                    Console.Write(" " + field[i, j] + "");

                }
                Console.WriteLine("");
            }
        }

        private static Random rnd = new Random();

        static Boolean placeShip(int[,] field, int ship)
        {
            int[,] locField = new int[field.GetLength(0), field.GetLength(1)];
            Array.Copy(field, locField, field.Length);

            // ship - from 1 to 4
            // coords
            int x = rnd.Next(0, 10);
            int y = rnd.Next(0, 10);

            // direction
            int d = rnd.Next(0, 2);

            Console.WriteLine($"Placing {ship} in {x},{y} direction {d}");

            if (d == 0)
            {
                try
                {
                    if (locField[x - 1, y - 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x - 1, y] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x - 1, y + 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }

                for (int i = 0; i <= (ship - 1); i++)
                {
                    try
                    {
                        if (locField[x + i, y] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { return false; }

                    try
                    {
                        if (locField[x + i, y - 1] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        if (locField[x + i, y + 1] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { }

                    locField[x + i, y] = ship;
                }

                try
                {
                    if (locField[x + ship, y - 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x + ship, y] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x + ship, y + 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }

                

            }
            else
            {
                // by y 
                try
                {
                    if (locField[x - 1, y - 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x , y - 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x + 1, y - 1] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }

                for (int i = 0; i <= (ship - 1); i++)
                {
                    try
                    {
                        if (locField[x, y + i] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { return false; }

                    try
                    {
                        if (locField[x - 1, y + i] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { }
                    try
                    {
                        if (locField[x + 1, y + i] > 0)
                        {
                            return false;
                        }
                    }
                    catch (IndexOutOfRangeException e) { }

                    locField[x, y + i] = ship;
                }

                try
                {
                    if (locField[x -1, y + ship] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x, y + ship] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
                try
                {
                    if (locField[x + 1, y + ship] > 0)
                    {
                        return false;
                    }
                }
                catch (IndexOutOfRangeException e) { }
            }

            Array.Copy(locField, field, locField.Length);
            return true;
        }

        public static void fillField(int[,] arr)
        {
            for (int ship = 4; ship >= 1; ship--)
            {
                for (int cnt = (5 - ship); cnt >= 1; cnt--)
                {
                    Console.WriteLine($"{ship} \t {cnt}");
                    while (!placeShip(arr, ship)) { }
                    printarr2(arr);
                }

            }

        }




        //ОСНОВНОЙ МЕТОД ДЛЯ ИГРЫ В МОРСКОЙ БОЙ
        public static void Start()
        {
            Console.WriteLine("I'm a seabattle game");

            int[,] field = new int[10, 10];

            printarr2(field);

            int[,] fieldfp = new int[10, 10]; //field for player

            fillField(fieldfp);

        }
    }
}
