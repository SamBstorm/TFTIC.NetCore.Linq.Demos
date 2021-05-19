using System;
using System.Collections.Generic;
using System.Text;
using TFTIC.NetCore.Linq.Demos.Models;

namespace TFTIC.NetCore.Linq.Demos.Extentions
{
    public static class PersonneExtentions
    {
        public static void SePresenter(this Personne personne)
        {
            Console.WriteLine($"Je suis {personne.FirstName} {personne.Name}, et j'ai {DateTime.Now.Year - personne.BirthDate.Year} an(s).");
        }
    }
}
