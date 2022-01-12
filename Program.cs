using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APP0
{
    internal class Program
    {
        static int[] list = new int[9];
        static void Main(string[] args)
        {

            list[0] = 0;
            list[1] = 0;
            list[2] = 0;
            list[3] = 0;
            list[4] = 0;
            list[5] = 0;
            list[6] = 0;
            list[7] = 0;
            list[8] = 0;

            while ()
            {



                for (int i = 0; i < 9; i++)
                {



                    int user;
                    Console.WriteLine("choose a nomber between 1 and 9:");
                    user = int.Parse(Console.ReadLine());
                    if (list[user] == 0)
                    {
                        list[user] = 1;
                    }
                    checkforwinner();
                    board();

                    Random random = new Random();
                    int computer = random.Next(0, 8);
                    if (list[computer] == 0)
                    {
                        list[computer] = 2;
                    }
                    checkforwinner();
                    board();
                }
                //display result ser
                void board()
                {
                    for (int i = 0; i < 9; i++)
                    {

                        if (list[i] == 1)
                        {
                            Console.Write("O");
                        }
                        if (list[i] == 2)
                        {
                            Console.Write("X");
                        }
                        if (list[i] == 0)
                        {
                            Console.Write(".");
                        }
                        if (i == 2 || i == 5 || i == 8)
                        {
                            Console.WriteLine();
                        }


                    }
                }
            }
            

        }
        //win cases
        private static int checkforwinner()
        {
            if (list[1] == list[2] || list[1] == list[3])
            {
                return list[1];
            }
            if (list[4] == list[5] || list[4] == list[6])
            {
                return list[4];
            }
            if (list[7] == list[8] || list[7] == list[9])
            {
                return list[7];
            }
            if (list[1] == list[5] || list[1] == list[9])
            {
                return list[1];
            }
            if (list[3] == list[5] || list[3] == list[7])
            {
                return list[3];
            }
            if (list[1] == list[4] || list[1] == list[7])
            {
                return list[1];
            }
            if (list[2] == list[5] || list[2] == list[8])
            {
                return list[2];
            }
            if (list[3] == list[6] || list[3] == list[9])
            {
                return list[3];
            }

            return 0;
        }
        
        
    }
}
