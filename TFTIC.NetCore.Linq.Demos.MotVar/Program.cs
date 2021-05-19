using System;
using System.Collections.Generic;
using TFTIC.NetCore.Linq.Demos.Models;

namespace TFTIC.NetCore.Linq.Demos.MotVar
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 5;
            i = 6;
            //i = "hello";

            //foreach (var p  in new List<Personne>())
            //{

            //}

            Personne p = new Personne() { Id=1, Name = "Toto", FirstName = "Titi", BirthDate = DateTime.Now };
            Item item1 = new Item() { Name = "Casque" };
            Item item2 = new Item() { Name = "Fusil" };

            var soldat = new { Id = p.Id, Name = p.Name, FirstName = p.FirstName, BirthDate = p.BirthDate, Inventory = new List<Item> { item1, item2 } };

            Console.WriteLine( soldat.Inventory[1].Name ); 
        }
    }
}
