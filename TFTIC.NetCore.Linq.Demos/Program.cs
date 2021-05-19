using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TFTIC.NetCore.Linq.Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>() { "Lloyd", "Johan", "Xavier", "Stephan", "Stephanie", "Delphine", "Hortance", "Alice", "Julie", "Grégory", "Walid", "Sebastien", "Allan" };
            ArrayList listOfObjects = new ArrayList(strings.ToArray());

            //foreach (var str in listOfObjects)
            //{
            //}

            #region Cast<T>()
            /*
             * IEnumerable<string> castResult = listOfObjects.Cast<string>();
            castResult = from string s in listOfObjects
                         select s;
            foreach (var str in castResult)
            {
                Console.WriteLine(str);
            } */
            #endregion

            #region OfType<T>()
            //listOfObjects.Add(new object());

            //IEnumerable<string> ofTypeResult = listOfObjects.OfType<string>();
            //ofTypeResult = from string s in listOfObjects.OfType<string>()
            //               select s;
            //foreach (var str in ofTypeResult)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.WriteLine($"Count of listOfObject {listOfObjects.Count} | Count of ofTypeResult {ofTypeResult.Count()}"); 
            #endregion

            #region Where()
            //IEnumerable<string> WhereResult = strings.Where(s => s.ToLower()[0] == 'a');
            //WhereResult = from s in strings
            //              where s.ToLower()[0] == 'a'
            //              select s;
            //foreach (string s in WhereResult)
            //{
            //    Console.WriteLine(s);
            //}
            #endregion

            #region Select()
            #region Select avec type défini
            //IEnumerable<Student> SelectResult = strings.Select(s => new Student { Nom = s });
            //SelectResult = from s in strings
            //               select new Student { Nom = s };
            //foreach (Student student in SelectResult)
            //{
            //    Console.WriteLine(student.Nom);
            //} 
            #endregion

            #region Select avec type anonyme
            //var SelectResult = strings.Select(s => new { Nom = s });
            //SelectResult = from s in strings
            //               select new { Nom = s };
            //foreach (var student in SelectResult)
            //{
            //    Console.WriteLine(student.Nom);
            //} 
            #endregion

            #region Select converti, le Cast utilise l'héritage
            //IEnumerable<Student> students = strings.Select(s => new Student { Nom = s });
            //IEnumerable<Person> persons = students.Select(s => new Person { Nom = s.Nom });
            //var anonyms = persons.Select(p => new { p.Nom });

            ////IEnumerable<Person> personsByCast = students.Cast<Person>();

            ////foreach (var p in personsByCast)
            ////{
            ////    Console.WriteLine(p.Nom);
            ////} 
            #endregion
            #endregion
        }
    }

    class Student
    {
        public string Nom { get; set; }
    }

    class Person
    {
        public string Nom { get; set; }
    }
}
