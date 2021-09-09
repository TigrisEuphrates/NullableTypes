using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class DatabaseReader
    {
        public int? numericValue = null;
        public bool? boolValue = true;

        public int? GetIntFromDatabase()
        {
            return numericValue;
        }
        public bool? GetBoolFromDatabase()
        {
            return boolValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with Nullable Data\n");
            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();
            if (i.HasValue)
                Console.WriteLine($"Value of 'i' is: {i.Value}");
            else
                Console.WriteLine("Value of 'i' is undefined.");
            bool? b = dr.GetBoolFromDatabase();
            if(b!=null)
                Console.WriteLine($"Value of 'b' is: {b.Value}");
            else
                Console.WriteLine("Value of 'b' is undefined.");

            int myData = dr.GetIntFromDatabase() ?? 100;
            Console.WriteLine($"Value of 'myData' is: {myData}");
            string[] arg = new string[5];
            TesterMethod(null);
            Console.ReadLine();
        }
        static void LocalNullableVariablesUsingNullable()
        {
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
        static void TesterMethod(string[] args)
        {
            //if(args!=null)
            //    Console.WriteLine($"You sent me {args.Length} arguments.");
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }
    }
}
