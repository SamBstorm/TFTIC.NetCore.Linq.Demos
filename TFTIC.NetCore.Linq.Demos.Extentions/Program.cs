using System;
using TFTIC.NetCore.Linq.Demos.Models;

namespace TFTIC.NetCore.Linq.Demos.Extentions
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne() { Name = "Legrain", FirstName = "Samuel", BirthDate = new DateTime(1987, 09, 27) };
            p.SePresenter();
            Item item = new Item() { Name = "Ordinateur" };

            Console.WriteLine( p.GetId() );
            Console.WriteLine( item.GetId() );

        }
    }
}
