using System;
using System.IO;
using System.Text;

namespace HomeTask_5
{
    class Program
    {
         static void Main(string[] args)
        {
            //First Task

            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Firs Task\n");

            string[] lines = new string[] {"Дано #текст з #особливостями#,",
               "які можуть бути #відкоректовані#","дуже легко#."};

            lines = Replace.ReplaceSharp(lines);

            foreach (var line in lines)
            {
                Console.Write(line);
            }

            // Second Task

            Console.WriteLine("\n\nSecond Task\n");

            var cube = new int[3, 3, 3];

            Random rand = new Random();

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                for (int j = 0; j < cube.GetLength(0); j++)
                {
                    for (int n = 0; n < cube.GetLength(0); n++)
                    {
                        cube[i, j, n] = rand.Next()%2;
                    }
                }
            }

            int [,]shadow=Shadow.FindShadowInCube(cube, Axis.XOY);

            for (int i = 0; i < shadow.GetLength(0); i++)
            {
                for (int j = 0; j < shadow.GetLength(1); j++)
                {
                    Console.Write(shadow[i,j]+" ");
                }
                Console.WriteLine();
            }

            //Third Task

            Console.WriteLine("\nThird Task\n");

            string path = "c:\\WebServers\\home\\testsite\\www\\myfile.txt";

            //use my own class

            Console.WriteLine("File name without extension: " + MyPath.GetFileNameWithoutExtension(path));

            Console.WriteLine("Path root: " + MyPath.GetPathRoot(path));

            //use class from library

            Console.WriteLine("File name without extension: "+Path.GetFileNameWithoutExtension(path));

            Console.WriteLine("Path root: " + Path.GetPathRoot(path));




        }
    }
}
