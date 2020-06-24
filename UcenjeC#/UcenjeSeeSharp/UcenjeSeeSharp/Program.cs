using System;

namespace UcenjeSeeSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int cigan=600;
            int[] niza = new int[5];
            string[,] matrica = new string[5, 4];
            byte[][] scores = new byte[5][];


            for(int i =0;i< scores.Length;i++)
            {
                scores[i] = new byte[i + 3];
            }

            for(int i=0;i< scores.Length;i++)
            {
                Console.WriteLine("Length of row {0} is {1}", i, scores[i].Length);
            }

            System.Console.WriteLine("Hello World!");
        }
    }

    public class Cigan
    {
        private: 
            char ime, char prezime;
            int godini;
        public:
        Cigan(char ime="", char prezime="", int godini="")
        {
            this.ime = ime;
            this.prezime = prezime;
            this.godini = godini;
        }
    }
}
