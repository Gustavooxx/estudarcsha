﻿using System;
using System.Globalization;

namespace estudarcsha;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();

        Console.WriteLine($"Informe a primeira medida");
        int me1 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Informe a segunda medida");
        int me2 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Informe a terceira medida");
        int me3 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine($"Informe a quarta medida");
        int me4 = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine(Resu(me1, me2, me3, me4));

    }

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DO RETANGULOS");
    }

    public static string Resu(double nota1, double nota2, double nota3, double nota4)
    {
        double con = nota1 * nota2;

        double con2 = nota3 * nota4;

        string Resu = "";

        if (con != con2)
        {
            Resu = "Eles sao diferentes";
        }
        else if (con == con2)
        {
            Resu = "Eles sao iguais";
        }
        return Resu;
    }
}
