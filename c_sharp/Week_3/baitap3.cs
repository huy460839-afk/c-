using System;

namespace Week3;

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            bai1();
        }
        static void bai1()
        {
        Console.WriteLine("Enter first number:");
        float num1 = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        float num2 = Convert.ToSingle(Console.ReadLine());
        float sum = num1 + num2;
        float minus = num1 - num2;
        float multiply = num1 * num2;
        float divide = num1 / num2;
        float mod = num1 % num2;
        Console.WriteLine($"{num1} + {num2} = {sum}");
        Console.WriteLine($"{num1} - {num2} = {minus}");
        Console.WriteLine($"{num1} * {num2} = {multiply}");
        Console.WriteLine($"{num1} / {num2} = {divide}");
        }
        static void bai2()
        {
            for (int y = -5 ; y <= 5; y++)
            {
                int x = y * y + 2 * y + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }    
        }
        static void bai3()
        {
            Console.WriteLine("Enter a distance:");
           double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a hours:");
                double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a minutes:");
                double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter a seconds:");
                double s = Convert.ToDouble(Console.ReadLine());
            double totalh = h + m / 60f + s / 3600f;
            double speed = d / totalh;
            Console.WriteLine($"Speed = {speed} km/h = {speed / 1.609f} miles/h");
        }
        static void bai4()
        {
         Console.WriteLine("Enter radius of sphere:");
            float radius = Convert.ToSingle(Console.ReadLine());
            float surface = 4 * MathF.PI * radius * radius;
            float volume = (4f / 3f) * MathF.PI * radius * radius * radius;
            Console.WriteLine($"Surface area is {surface}");
            Console.WriteLine($"Volume is {volume}");
        }
        static void bai5()
        {
           Console.WriteLine("Enter character");
            char c = Convert.ToChar(Console.ReadLine());
           char cl = char.ToLower(c);
           if (cl == 'a' || cl == 'e' || cl == 'i' || cl == 'o' || cl == 'u')
            {
                Console.WriteLine($"{c} is a vowel");
            }
              else if(char.IsDigit(cl))
            {
                Console.WriteLine($"{c} is a digit");
            }
            else
            {
                Console.WriteLine($"{c} other symbol");
            }
        }
    }
    
