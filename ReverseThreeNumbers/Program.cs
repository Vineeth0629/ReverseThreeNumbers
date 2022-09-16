// See https://aka.ms/new-console-template for more information

namespace ReverseThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling the functions
            ReverseCharacters();
            ReverseStrings();
        }

        private static void ReverseCharacters()
        {
            //Declare char type variable
            char letter, letter1, letter2;
            
            //Read input from console
            Console.Write("Input first letter: ");
            //As ReadLine() returns string, so convert string to char
            letter = Convert.ToChar(Console.ReadLine());
           
            Console.Write("Input second letter: ");
            //As ReadLine() returns string, so convert string to char
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Input third letter: ");
            //As ReadLine() returns string, so convert string to char
            letter2 = Convert.ToChar(Console.ReadLine());


            Console.WriteLine("{2} {1} {0}", letter, letter1, letter2);

        }

        private static void ReverseStrings()
        {
            //Declare char type variable
            string letter, letter1, letter2;

            //Read input from console
            Console.Write("Input first letter: ");
            //As ReadLine() returns string, so convert string to char
            letter = Console.ReadLine();

            Console.Write("Input second letter: ");
            //As ReadLine() returns string, so convert string to char
            letter1 = Console.ReadLine();

            Console.Write("Input third letter: ");
            //As ReadLine() returns string, so convert string to char
            letter2 = Console.ReadLine();


            Console.WriteLine("{2} {1} {0}", letter, letter1, letter2);

        }
    }
}