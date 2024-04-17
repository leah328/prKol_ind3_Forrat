using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace var_4
{
    class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("array.txt"))
            {
                Array array = new Array();
                ArrayList arrayList = new ArrayList();
                int size = 0, index = 0, numb = 0,j=0;
                string operation = "", continues = "";
                do
                {
                    do
                    {
                        Console.Write("введите размер массива: ");
                        try
                        {
                            size = int.Parse(Console.ReadLine());
                        }
                        catch { Console.WriteLine("error"); }

                    }
                    while (size <= 0 || size > 20);
                    int[] mass = array.Size(size);   
                    for (int i = 0; i < mass.Length; i++)
                    {
                        Console.Write($"{mass[i]} ");
                    }
                    StreamWriter r = File.CreateText("array.txt");
                    for (int i = 0; i < mass.Length; i++)
                        r.WriteLine(mass[i]);
                    r.Close();
                    do
                    {
                        Console.Write("\nвведите индекс элемента, чтобы его вывести (отсчет начинается с 1): ");
                        try
                        {
                            index = int.Parse(Console.ReadLine()) - 1;
                            if (index > mass.Length) Console.WriteLine("вы вышли за границы массива");
                            if (index < 0) Console.WriteLine("число не должно быть меньше 1!");
                        }
                        catch { Console.WriteLine("error"); }

                    }
                    while (index < 0|| index > mass.Length);
                    Console.WriteLine($"{array.Element(mass, index)}");
                    do
                    {
                        Console.Write("введите индекс элемента, чтобы начиная с него вывести массив (отсчет начинается с 1): ");
                        try
                        {
                            index = int.Parse(Console.ReadLine()) - 1;
                            if (index > mass.Length) Console.WriteLine("вы вышли за границы массива");
                            if (index < 0) Console.WriteLine("число не должно быть меньше 1!");
                        }
                        catch { Console.WriteLine("error"); }

                    }
                    while (index < 0 || index > mass.Length);
                    int[] sup = array.Out(mass, index);
                    for (int i = 0; i < sup.Count(); i++)
                    {
                        Console.Write($"{sup[i]} ");
                    }
                        try
                        {
                        Console.Write("\nвведите число, на которое нужно умножить массив: ");
                        numb = int.Parse(Console.ReadLine());
                        
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("error");                        
                        }
                    int[] sup2 = array.Multiply(mass, numb);
                    for (int i = 0; i < sup2.Count(); i++)
                    {
                        Console.Write($"{sup2[i]} ");
                    }
                        do
                        {
                            Console.Write("\nвыберите операцию: + или -: ");
                            operation = Convert.ToString(Console.ReadLine());
                        }
                        while (!(operation == "+" || operation == "-"));
                        int[] mass2 = array.Size(mass.Length);
                        int[] massev = new int[mass.Length];
                        StreamReader sr = File.OpenText("array.txt");
                        while (!sr.EndOfStream)
                        {
                        massev[j] = Convert.ToInt32(sr.ReadLine());
                            j++;
                        }
                        sr.Close();
                        Console.Write("первый массив: ");
                        for (int i = 0; i < massev.Length; i++)
                        {
                            Console.Write($"{massev[i]} ");
                        }
                        Console.Write("\nвторой массив: ");
                        for (int i = 0; i < mass2.Length; i++)
                        {
                            Console.Write($"{mass2[i]} ");
                        }
                        arrayList = array.Operation(massev, mass2, operation);
                        Console.Write("\nрезультат: ");
                        foreach (object action in arrayList)
                        {
                            Console.Write($"{action} ");
                        }

                    Console.Write("\nчтобы продолжить выполнение программы напишите 'X', чтобы завершить 'Y':");
                    continues = Convert.ToString(Console.ReadLine());

                }
                while (continues == "X");
                if (continues == "Y") Console.WriteLine("выполнение завершено");
            }
            else Console.WriteLine("файл 'array.txt' не найден!");

            Console.ReadKey();
        }
    }
}
