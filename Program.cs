using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
delegate void num();
namespace ConsoleApplication_multicast
{
    class Program
    {

        public static void add()
        {
            int a, b;
            string a1, b1;
            Console.Write("Введите 2 числа ");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Int32.Parse(a1);
            b = Int32.Parse(b1);
            int s = a + b;
            Console.WriteLine("Ответ = " + s);
        }
        public static void sub()
        {
            int a, b;
            string a1, b1;
            Console.Write("Введите 2 числа ");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Int32.Parse(a1);
            b = Int32.Parse(b1);
            int d = a - b;
            Console.WriteLine("Ответ = " + d);
        }
        public static void mul()
        {
            int a, b;
            string a1, b1;
            Console.Write("Введите 2 числа ");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Int32.Parse(a1);
            b = Int32.Parse(b1);
            int p = a * b;
            Console.WriteLine("Ответ = " + p);
        }
        public static void div()
        {
            int a, b;
            string a1, b1;
            Console.Write("Введите 2 числа ");
            a1 = Console.ReadLine();
            b1 = Console.ReadLine();
            a = Int32.Parse(a1);
            b = Int32.Parse(b1);
            int q = a / b;
            Console.WriteLine("Ответ = " + q);
        }
        static void Main(string[] args)
        {
            num cal1 = new num(add);
            num cal2 = new num(sub);
            num cal3 = new num(mul);
            num cal4 = new num(div);
            Console.WriteLine("Арифметические операции \n1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление \nВыбор:");
            string ch = Console.ReadLine();
            int c = Int32.Parse(ch);
            switch (c)
            {
                case 1:
                    Console.WriteLine("Сложение");
                    cal1();
                    break;
                case 2:
                    Console.WriteLine("Вычитание");
                    cal2();
                    break;
                case 3:
                    Console.WriteLine("Умножение");
                    cal3();
                    break;
                case 4:
                    Console.WriteLine("Деление");
                    cal4();
                    break;
                default:
                    Console.WriteLine("Нет");
                    break;
            }
            Console.ReadLine();
        }
    }
}