using System;
using static System.Console;
using static booleanOperators.Utils;

namespace booleanOperators
{
    public class Program
    {


        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            //log come stringa semplice
            WriteLine($"AND  | a     | b    ");


            WriteLine($"a    | {a & a,-5} | {a & b,-5} ");
            WriteLine($"b    | {b & a,-5} | {b & b,-5} ");
            WriteLine();

            WriteLine($"OR   | a     | b    ");
            WriteLine($"a    | {a | a,-5} | {a | b,-5} ");
            WriteLine($"b    | {b | a,-5} | {b | b,-5} ");
            WriteLine();
            WriteLine($"XOR  | a     | b    ");
            WriteLine($"a    | {a ^ a,-5} | {a ^ b,-5} ");
            WriteLine($"b    | {b ^ a,-5} | {b ^ b,-5} ");

            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");



            //operazioni con i booleani
            WriteLine("inserisci un Nome");
            string Nome = ReadLine();

            if (ContieneValore(Nome))
            {
                WriteLine($"il nome è {Nome}");
            }
            else
            {
                WriteLine("IL VALORE DI NOME NON DEVE ESSERE VUOTO!");
            }

            WriteLine($"Nome && DoStuff() = {ContieneValore(Nome) && DoStuff()}");


        }
    }
}