﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaForEach
    {
        public static void Executar()
        {
            var palavra = "Opa!";

            foreach (var letra in palavra)
            {
                Console.WriteLine(letra);
            }
            var alunos = new String[] { "Ana", "Bia", "Dali" };
            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }
        }
    }
}
