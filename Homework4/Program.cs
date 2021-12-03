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

            //Part 1

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

            //Part 2

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

            Console.Write($"Минимальное число: {minVar}\n\n\n");

            //Part 3

            int maxValue = 0;


            do
            {
                Console.Write("Введите максимальное число: ");
                correctInput = int.TryParse(Console.ReadLine(), out maxValue);
                if (!correctInput)
                    Console.WriteLine("Некорректный ввод!\n\n");
            } while (!correctInput);

            int randomNum = rand.Next(maxValue);
            Console.Write($"Попробуйте угадать! Загаданое число 0 - {maxValue}: ");
            while (true)
            {
                string userTrySTR = Console.ReadLine();
                int userTry;
                correctInput = int.TryParse(userTrySTR, out userTry);
                if (userTrySTR == "")
                    break;

                if (!correctInput)
                {
                    Console.WriteLine("Неверный ввод, повторите попытку");
                }
                else
                {
                    if(userTry < randomNum)
                    {
                        Console.Write("Загаданое число больше, попробуйте еще раз: ");
                    }
                    else if (userTry > randomNum)
                    {
                        Console.Write("Загаданое число меньше, попробуйте еще раз: ");
                    }
                    else
                    {
                        Console.Write("Поздравляем! Вы победили!");
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
