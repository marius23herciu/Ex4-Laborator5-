using System;

namespace Ex4_Laborator5_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex 4
            //Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr - un string citit
            //de la tastatura, ignorand caseing-ul literelor.
            //Exemplu:
            //Input: Elena are mere
            //Output: e apare de 5 ori

            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            int numerotare = VerificareAparitiiCaracter(sir);
            char caracter = CaracerulCelMaiDes(sir);
            Console.WriteLine($"Caracterul {caracter} apare de {numerotare} ori.", caracter, numerotare);
        }
        static int VerificareAparitiiCaracter(string sir)
        {
            int numerotare = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                int contorTemporar = 0;
                for (int j = i; j < sir.Length; j++)
                {
                    if (Char.ToLower(sir[i]) == Char.ToLower(sir[j]))
                    {
                        contorTemporar++;
                    }
                }
                if (numerotare < contorTemporar)
                {
                    numerotare = contorTemporar;
                }
            }
            return numerotare;
        }
        static char CaracerulCelMaiDes(string sir)
        {
            char rezultat = new char();
            int numerotare = 0;
            for (int i = 0; i < sir.Length; i++)
            {
                int contorTemporar = 0;
                for (int j = i; j < sir.Length; j++)
                {
                    if (Char.ToLower(sir[i]) == Char.ToLower(sir[j]))
                    {
                        contorTemporar++;
                    }
                }
                if (numerotare < contorTemporar)
                {
                    numerotare = contorTemporar;
                    rezultat = Char.ToLower(sir[i]);
                }
            }
            return rezultat;
        }
    }
}
