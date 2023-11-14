using System;
using static System.Console;
using static trainingOperators.Utils;

namespace trainingOperators
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

            //if per verificare se NOME è vuoto
            if (ContieneValore(Nome))
            {
                WriteLine($"il nome è {Nome}");
            }
            else
            {
                WriteLine("IL VALORE DI NOME NON DEVE ESSERE VUOTO!");
            }

            WriteLine($"Nome && DoStuff() = {ContieneValore(Nome) && DoStuff()}");




            int giornoDellaSettimana = 3;

            switch (giornoDellaSettimana)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;


                case 3:
                    Console.WriteLine("Wednesday");
                    break;


                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;

            }
        }
    }
}