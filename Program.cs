﻿using System;

namespace estudarcsha;

class Program
{
    static void Main(string[] args)
    {
        Apresentacao();
        double diametro1 = DiametroCilindro1();
        double altura1 = AlturaCilindro1();
        double diametro2 = DiametroCilindro2();
        double altura2 = AlturaCilindro2();
        VerificarTransferencia(diametro1, altura1, diametro2, altura2);
    }

    public static void Apresentacao()
    {
        Console.WriteLine("PROGRAMA DE VERIFICAÇÃO DE TRANSFERÊNCIA DE VOLUME ENTRE CILINDROS");
    }

    public static double DiametroCilindro1()
    {
        Console.WriteLine("Informe o diâmetro do primeiro cilindro:");
        double diametro = Convert.ToDouble(Console.ReadLine());
        return diametro;
    }

    public static double AlturaCilindro1()
    {
        Console.WriteLine("Informe a altura do primeiro cilindro:");
        double altura = Convert.ToDouble(Console.ReadLine());
        return altura;
    }

    public static double DiametroCilindro2()
    {
        Console.WriteLine("Informe o diâmetro do segundo cilindro:");
        double diametro = Convert.ToDouble(Console.ReadLine());
        return diametro;
    }

    public static double AlturaCilindro2()
    {
        Console.WriteLine("Informe a altura do segundo cilindro:");
        double altura = Convert.ToDouble(Console.ReadLine());
        return altura;
    }

    public static double CalcularVolume(double diametro, double altura)
    {
        double raio = diametro / 2.0;
        return Math.PI * raio * raio * altura;
    }

    public static void VerificarTransferencia(double diametro1, double altura1, double diametro2, double altura2)
    {
        double volume1 = CalcularVolume(diametro1, altura1);
        double volume2 = CalcularVolume(diametro2, altura2);
        Console.WriteLine($"O primeiro cilindro tem volume de {volume1}");
        Console.WriteLine($"O segundo cilindro tem volume de {volume2}");
        bool possivel = volume1 <= volume2;
        Console.WriteLine($"É possível transferir o primeiro para o segundo? {possivel.ToString().ToLower()}");
    }
}
