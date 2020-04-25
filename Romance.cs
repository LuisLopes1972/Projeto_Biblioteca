

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// -------------------------------------------------
// <copyright file="Romance.cs">
// </copyright - 13815_António Luís Ferreira Lopes>
// <summary>
//	LP2 - 2019-2020
// <OOP, Herança>
// </summary>
//-------------------------------------------------

namespace Exemplo_Heranca
{
    public class Romance : Maias
    {
        public new string Nome = "Maias";

        public void MostrarValores()
        {
            Console.WriteLine("Nome Romance: " + Nome);
            Console.WriteLine("Nome Autor: " + base.Nome);

        }
    }
}
