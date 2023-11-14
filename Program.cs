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
            //operazioni con i booleani
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



            
            WriteLine("inserisci un Nome");
            string Nome = ReadLine();

            //condizionale if per verificare se NOME è vuoto
            if (ContieneValore(Nome))
            {
                WriteLine($"il nome è {Nome}");
            }
            else
            {
                WriteLine("IL VALORE DI NOME NON DEVE ESSERE VUOTO!");
            }

            WriteLine($"Nome && DoStuff() = {ContieneValore(Nome) && DoStuff()}");



            
            int giornoDellaSettimana;
            Write("inserisci il numero del giorno della settimana:");
            var appoggio = ReadLine();

            if (int.TryParse(appoggio, out giornoDellaSettimana) && 
                (giornoDellaSettimana <8 & giornoDellaSettimana >1))
            {//condizionale SWITCH CASE
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
                WriteLine($"Il giorno selezionato è {giornoDellaSettimana}");
            } else { WriteLine("DEVI INSERIRE UN NUMERO FRA 1 E 7"); };


            //ARRAY: Cosa sono e cicli applicati->>
            string[] names; // can reference any array of strings

            // allocating memory for four strings in an array
            names = new string[5];

            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";
            names[4] = "Darth Vader";


            //Richiedere nuovo Nome
            //Conrollare nuovo nome

            //Ingrandire la Collection/Array
            //Array.Resize<string>(ref names, names.Length + 1);

            //Inserire nuovo vaore


            // looping through the names
            for (int i = 0; i < names.Length; i++)
            {
                // output the item at index position i
                Console.WriteLine(names[i]);
            }

            int index = 0;
            foreach (string item in names)
            {
                index++;
                Console.WriteLine(item);
            }


        }
    }
}