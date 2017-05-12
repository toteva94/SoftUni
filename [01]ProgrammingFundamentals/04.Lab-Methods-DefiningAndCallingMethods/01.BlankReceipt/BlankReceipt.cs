namespace _01.BlankReceipt
{
    using System;

   public class BlankReceipt
    {
       public static void Main(string[] args)
        {
            PrintReceipt();
        }

       static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }
        static void PrintBody()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }
        static void PrintFooter()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }
    }
}
