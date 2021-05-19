using System;
using System.Collections.Generic;

namespace TFTIC.NetCore.Linq.Demos.Lambdas
{
    class Program
    {
        delegate int MyDelegate(int x);

        delegate string FunctionDelegate(int i, int j);

        delegate void ActionDelegate(string text, int i);
        static void Main(string[] args)
        {
            #region Delegate and Lambda
            //MyDelegate f = x => x + 5;
            //Func<int, int> f2 = x => x + 5;

            //FunctionDelegate fd = (i, j) =>
            //{
            //    int result = i + j;
            //    return result.ToString();
            //};
            //Func<int, int, string> fd2 = (i, j) =>
            //{
            //    int result = i + j;
            //    return result.ToString();
            //};

            //ActionDelegate ad = (text, i) =>
            //{
            //    for (int j = 0; j < i; j++) Console.WriteLine(text);
            //};
            //Action<string, int> ad2 = (text, i) =>
            //{
            //    for (int j = 0; j < i; j++) Console.WriteLine(text);
            //};


            //ad($"Voici mon addition {fd(5, 5)}", f(5)); 
            #endregion

            int[] ints = new int[] { 3, 4, 1, 5,-7, 7, 8, 6 };
            List<string> strings = new List<string>() {"Lloyd","Johan","Xavier","Stephan", "Stephanie", "Delphine", "Hortance", "Alice", "Julie", "Grégory", "Walid", "Sebastien", "Allan" };
            Console.WriteLine( Filtrer(ints, (i)=> i % 2 == 0) );
            Console.WriteLine( Filtrer(ints, (i)=> i % 2 == 0) );
            Console.WriteLine( Filtrer(ints, (i)=> i % 2 != 0) );
            Console.WriteLine( Filtrer(ints, (i)=> i > 0) );
            Console.WriteLine( Filtrer(strings, (i)=> i.Length > 5) );
            Console.WriteLine( Filtrer(strings, (i)=> i.Length <= 5) );
            Console.WriteLine( Filtrer(strings, (i)=> i[0] == 'S') );
        }

        public static string Filtrer<T>(IEnumerable<T> list,Func<T,bool> actionFiltrante)
        {
            string result = "";
            foreach (T i in list)
            {
                if (actionFiltrante(i) == true) result += i.ToString();
            }
            return result;
        }
    }
}
