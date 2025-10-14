﻿using System;
using System.Globalization;

namespace estudarcsha;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("PROGRAMA DO ALUNO");

        Console.WriteLine("informe a primeira nota do aluno:");
        double nota1 = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("informe a segunda nota do aluno:");
        double nota2 = Convert.ToDouble(Console.ReadLine());

         Console.WriteLine("informe a terceira nota do aluno:");
        double nota3 = Convert.ToDouble(Console.ReadLine());

        double nota = (nota1 + nota2 + nota3) / 3;
        string situ = Resu(nota1, nota2, nota3);

        Console.WriteLine($"A nota do aluno é {nota}");
        Console.WriteLine($"{situ}");
    }

    public static string Resu(double nota1, double nota2, double nota3)
    {
        double nota = (nota1 + nota2 + nota3) / 3;
        string passou = "";

        if (nota > 5)
        {
            passou = $"aluno passou";
        }
        else 
        {
            passou = $"aluno reprovou";
        }
        return passou;
    }
}
