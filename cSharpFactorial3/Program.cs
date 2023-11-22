using System;

namespace cSharpFactorial3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i, fact=1;
            Console.Write("Enter a number...: ");
            num = int.Parse(Console.ReadLine());

            for(i=num; i>0; i--)
            {
                fact = fact *i;
            }
            Console.WriteLine(fact);

        }
    }
}
