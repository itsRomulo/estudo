﻿using System;
using System.Globalization;

namespace Primeiro
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 4500.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, cujo preço é R$ {1:F2} ", produto1 , preco1);
            Console.WriteLine("{0}, cujo preço é R$ {1:F2}", produto2, preco2);
            Console.WriteLine();
            Console.WriteLine("Registro: {0} anos de idade, código {1} e gênero: {2}", idade, codigo, genero);
            Console.WriteLine();
            Console.WriteLine("Medida com oito casas decimais: {0:F8}", medida);
            Console.WriteLine("Arrendondado: {0:F3}", medida);
            Console.WriteLine("Com ponto:", medida.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
