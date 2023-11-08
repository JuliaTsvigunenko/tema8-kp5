using System;

namespace ConsoleApp1
{
    class Program
    {

        // Самостоятельная работа

        //public static double Dif(double x, double y)

        //{
        //    double dif = x - y;
        //    return dif;
        //}

        //static void Main(string[] args)

        //{

        //    Console.Write("Введите x= ");
        //    double x = double.Parse(Console.ReadLine());

        //    Console.Write("Введите y= ");
        //    double y = double.Parse(Console.ReadLine());

        //    double Razn = Dif(x, y);
        //    Console.Write($"Разность={Razn}");
        //    Console.ReadKey();

        //}



        //Вариант 1 (Уровень А)

        //1

        //static double Func(int x)

        //{
        //    double y = (x + Math.Sin(x)) / 3;
        //    return y;
        //}

        //static void Main(string[] args)

        //{
        //    double y = Func(1) + Func(5) + Func(7);
        //    Console.WriteLine(y);
        //    Console.ReadKey();
        //}


        //2

        //static int Seconds(int h, int m, int s)
        //{
        //    m += h * 60;
        //    s += m * 60;

        //    return h * 3600 + m * 60 + s;
        //}

        //static void Main(string[] args)

        //{
        //    Console.Write("Введите h:");
        //    int h = int.Parse(Console.ReadLine());
        //    Console.Write("Введите m:");
        //    int m = int.Parse(Console.ReadLine());
        //    Console.Write("Введите s:");
        //    int s = int.Parse(Console.ReadLine());

        //    int z = Seconds(h, m, s);
        //    Console.WriteLine($"z={z}");

        //    Console.ReadKey();
        //}



        //Вариант 2 (Уровень А)

        //1

        //static double Func(double x, double y)
        //{
        //    double z = (Math.Sqrt(y) + x) / 2;
        //    return z;
        //}

        //static void Main(string[] args)
        //{
        //    double func = Func(6, 6) + Func(13, 13) + Func(21, 21);
        //    Console.WriteLine($"y={func}");
        //    Console.ReadKey();
        //}


        //2

        //static int Meters(int k, int m)
        //{
        //  return k* 1000 + m;
        //}

        //static void Main(string[] args)
        //{
        //    Console.Write("Введите k:");
        //    int k = int.Parse(Console.ReadLine());
        //    Console.Write("Введите m:");
        //    int m = int.Parse(Console.ReadLine());
           
        //    int s = Meters(k,m);
        //    Console.WriteLine($"s={s}");
        //}



    }
}
