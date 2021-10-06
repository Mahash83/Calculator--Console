using System;

namespace training2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("*calculator*");
            System.Console.WriteLine("operators :\nmenha: -\t jam: +\t zarb: *\t tagsim: /\t tavan: ** ");

            Console.WriteLine("Please enter the first number:");
            var a = new adad();
            a.x = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operator you want to use:");
            string c = Console.ReadLine() ;
            
            
            Console.WriteLine("Enter the last number:");
            var b = new adad();
             b.y = int.Parse(Console.ReadLine());

             if (c=="-")
            {
                System.Console.WriteLine($"Result: {a.x - b.y }");
            }
            if (c=="+")
            {
                System.Console.WriteLine($"Result: {a.x + b.y }");
            }
             if (c=="*")
            {
                System.Console.WriteLine($"Result: {a.x * b.y }");
            }
            if (c=="/")
            {
                System.Console.WriteLine($"Result: {a.x / b.y }");
            }
            if (c=="**")
            {
                System.Console.WriteLine($"Result: {a.tavan(a.x , b.y )}");
            }
            
         
            Console.ReadKey();

         
            
        }
    }
}
