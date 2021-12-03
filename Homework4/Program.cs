using System;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            int width, height, arrLength;
            bool correctW, correctH, correctInput;
            Random rand = new Random();
            do
            {
                Console.WriteLine("Введите ширину, а затем высоту массива: ");
                correctW = int.TryParse(Console.ReadLine(), out width);
                correctH = int.TryParse(Console.ReadLine(), out height);
                if (!correctW || !correctH)
                    Console.WriteLine("Некорректный ввод!\n\n");
            } while (!correctW || !correctH);

            Console.WriteLine("\n\n\n");
            int[,] arr = new int[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write(arr[i, j] + "    ");
                }
                Console.WriteLine();
            }

            do
            {
                Console.WriteLine("\n\nВведите длинну массива:");
                correctInput = int.TryParse(Console.ReadLine(), out arrLength);
                if (!correctInput)
                    Console.WriteLine("Некорректный ввод!\n\n");
            } while (!correctInput);
            int[] userArr = new int[arrLength];
            int minVar = 0;
            
            for(int i = 0; i < arrLength;)
            {
                do
                {
                    Console.Write($"Введите {i + 1} число: ");
                    correctInput = int.TryParse(Console.ReadLine(), out userArr[i]);
                    if (!correctInput)
                        Console.WriteLine("Некорректный ввод!\n\n");
                } while (!correctInput);

                if (i == 0)
                {
                    minVar = userArr[i];
                }
                else
                {
                    minVar = Math.Min(minVar, userArr[i]);
                }

                i++;
            }

            Console.Write($"Минимальное число: {minVar}");
            Console.ReadKey();
        }
    }
}
