// -------------------------------------------------
// <copyright file="Program.cs">
// </copyright - 13815_António Luís Ferreira Lopes>
// <summary>
//	LP2 - 2019-2020
// <OOP, Herança>
// </summary>
//-------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {            
            Publicacoes objPublicacoes = new Publicacoes();
            objPublicacoes.Livro = 1888;

            Livro objLivro = new Livro();
            objLivro.MostrarValores();

            Publicacoes objPublicacoes = new Publicacoes();
            objPublicacoes.Revista = 2000;

            Revista objRevista = new Revista();
            objRevista.MostrarValores();

            Publicacoes objPublicacoes = new Publicacoes();
            objPublicacoes.Jornais = 1974;

            Jornais objJornais = new Jornais();
            objJornais.MostrarValores();

            Console.ReadKey();
        }
    }
}

