﻿using System;
using System.Globalization;

namespace estudarcsha;

class Program
{
    static void Main(string[] args)
    {

        Apresentacao();

        string num = pegarSinal();

        Console.WriteLine(Resu(num));
    }   

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DO IMPAR E PAR");


    }

    public static string pegarSinal()
    {
        Console.WriteLine("informe um numero:");
        string num = Console.ReadLine();
        return num;
    }

    public static string Resu(string sinal)
    {
        string sin = "verde";
        bool v = sinal == sin;
        string re = $"pode atravessar? {v}";
        return re;

    }
}
