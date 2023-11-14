using System;

namespace booleanOperators
{
    public class Utils
    {
        public static bool ContieneValore(string NomeDaControllare)
        {
            if ((NomeDaControllare == null) || (NomeDaControllare == string.Empty))
            {
                return false;
            }
            return true;
        }

        public static bool DoStuff()
        {
            Console.WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
