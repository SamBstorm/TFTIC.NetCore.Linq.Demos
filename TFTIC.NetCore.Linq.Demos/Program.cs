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

            List<BookGender> Genders = new List<BookGender> { 
                new BookGender() { Id = 1, Name = "Novel" },
                new BookGender() { Id = 2, Name = "Poem" },
                new BookGender() { Id = 3, Name = "Horror" },
                new BookGender() { Id = 4, Name = "Manual" },
                new BookGender() { Id = 5, Name = "Fiction" }
            };

            List<Book> Books = new List<Book>()
            {
                new Book() {ISBN = "00123400" , Title= "LinQ pour les nuls" , Gender_Id = 4 },
                new Book() {ISBN = "00123401", Title= "C# est le relationnel" , Gender_Id = 4 },
                new Book() {ISBN = "00123402", Title= "DeLaFontaine, Avant et maintenant", Gender_Id = 2 },
                new Book() {ISBN = "00123403", Title= "Où es-tu?", Gender_Id = 1 },
                new Book() {ISBN = "00123404", Title= "Star Trek - Le nouveau voyage", Gender_Id = 5},
                new Book() {ISBN = "00123405", Title= "Star Wars - Un nouvel Episode", Gender_Id = 5}
            };

            #region GroupBy()

            //IEnumerable<IGrouping<int, Book>> booksByNumberOfCharacters = Books.GroupBy(b => b.Title.Length);

            //booksByNumberOfCharacters = from b in Books
            //                            group b by b.Title.Length;

            //foreach (IGrouping<int,Book> groupOfBooks in booksByNumberOfCharacters)
            //{
            //    Console.WriteLine($"Les livres dont le titre contient {groupOfBooks.Key} sont : ");
            //    foreach (Book book in groupOfBooks)
            //    {
            //        Console.WriteLine($"\t- {book.Title}");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Join() == Inner Join

            //var BooksWithGender = Books.Join(Genders,
            //                                    b => b.Gender_Id,
            //                                    g => g.Id,
            //                                    (b, g) => new { b.ISBN, b.Title, Gender_Name = g.Name });

            //BooksWithGender = from b in Books
            //                  join g in Genders on b.Gender_Id equals g.Id
            //                  select new { b.ISBN, b.Title, Gender_Name = g.Name };

            //foreach (var bookWithGender in BooksWithGender)
            //{
            //    Console.WriteLine($"{bookWithGender.ISBN} - {bookWithGender.Title} : {bookWithGender.Gender_Name}");
            //}

            #endregion

            #region GroupJoin() == Left Outer Join

            //var BooksByGender = Genders.GroupJoin(Books,
            //                                        g => g.Id,
            //                                        b => b.Gender_Id,
            //                                        (g,books) => new
            //                                        {
            //                                            Gender = g.Name,
            //                                            Books = books.Select(b=> b.Title)
            //                                        }
            //    );

            //BooksByGender = from g in Genders
            //                join b in Books on g.Id equals b.Gender_Id into books
            //                select new
            //                {
            //                    Gender = g.Name,
            //                    Books = books.Select(b => b.Title)
            //                };

            //foreach (var booksByGender in BooksByGender)
            //{
            //    Console.WriteLine($"{booksByGender.Gender} :");
            //    if (booksByGender.Books.Count() > 0) foreach (string Title in booksByGender.Books)
            //        {
            //            Console.WriteLine(Title);
            //        }
            //    else Console.WriteLine("Pas de livre de ce genre ici...");
            //}

            #endregion

            #region Multiple from == CrossJoin

            var AllBooksAllGenders = from b in Books
                                     from g in Genders
                                     select new { b.Title, g.Name };

            AllBooksAllGenders = Books.Join(Genders,
                                            b => true,
                                            g => true,
                                            (b,g)=> new { b.Title, g.Name }
                );

            foreach (var bookWithGender in AllBooksAllGenders)
            {
                Console.WriteLine($"{bookWithGender.Title} - {bookWithGender.Name}");
            }

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

    public class Book { 
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Gender_Id { get; set; }
    }

    public class BookGender
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
