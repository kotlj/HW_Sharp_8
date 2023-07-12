using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Pair
    {
        public int generate()
        {
            Random r = new Random();
            int value = r.Next(0, 1000);
            while (true)
            {
                if (value % 2 == 0)
                {
                    return value;
                }
                value = r.Next(0, 1000);
            }
        }
    }
    class Prime
    {
        public int generate()
        {
            Random r = new Random();
            int value = r.Next(0, 1000);
            while (true)
            {
                int counter = 0;
                for (int i = 2; i < value; i++)
                {
                    if (value % i == 0)
                    {
                        counter++;
                    }
                }
                if (counter == 0)
                {
                    return value;
                }
                value = r.Next(0, 1000);
            }
        }
    }
    class Fibo
    {
        public int generate()
        {
            Random r = new Random();
            int value = r.Next(0, 1000);
            while (true)
            {
                double pow = Math.Pow(value, 2);
                if ((Math.Sqrt(5 * (pow) - 4)) % 1 == 0 || (Math.Sqrt(5 * (pow) + 4)) % 1 == 0)
                {
                    return value;
                }
                value = r.Next(0, 1000);
            }
        }
    }
}
namespace Figure
{
    class Square
    {
        public void print(int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                if (i == 0 || i == lenght - 1)
                {
                    for (int y = 0; y < lenght; y++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int y = 0; y < lenght - 2; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }
    }
    class Rectangle
    {
        public void print(int height, int lenght)
        {
            for (int i = 0; i < height; i++)
            {
                if (i == 0 || i == height - 1)
                {
                    for (int y = 0; y < lenght; y++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    for (int y = 0; y < lenght - 2; y++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("*");
                }
                Console.Write('\n');
            }
        }
    }
    class Triangle
    {
        public void print(int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                for (int y = 1; y < lenght * 2; y++)
                {
                    if (y == lenght - i || y == lenght + i || i == lenght - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
namespace GuesGame
{
    class Game
    {
        public void play(int low, int high)
        {
            Random r = new Random();
            char answer = ' ';
            while (true)
            {
                int value = r.Next(low, high);
                Console.WriteLine($"Your number is: {value}?\ny - yes       n - no");
                answer = Convert.ToChar(Console.Read());
                if (answer == 'y')
                {
                    Console.WriteLine("End of game");
                    return;
                }
            }
        }
    }
}
namespace PseText
{
    class generator
    {
        public void generate(int numberOfVowels, int numberOfHowels, int lenght)
        {
            Random r = new Random();
            int counterV = 0;
            int counterH = 0;
            string Text = "";
            char c = ' ';
            while (true)
            {
                c = Convert.ToChar(r.Next(97, 121));
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
                {
                    if (counterV < numberOfVowels)
                    {
                        Text += c;
                        counterV++;
                    }
                }
                else
                {
                    if (counterH < numberOfHowels)
                    {
                        Text += c;
                        counterH++;
                    }
                }
                if (counterV == numberOfVowels && counterH == numberOfHowels || Text.Length == lenght)
                {
                    Console.WriteLine(Text);
                    return;
                }
            }
        }
    }
}

namespace HW_Sharp_8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            PseText.generator test = new PseText.generator();
            test.generate(5, 5, 5);
        }
    }
}
