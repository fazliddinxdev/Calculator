using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.Arm;

namespace Calculator
{
    class Program
    {
        static void Main()
        {
            //butun son
            // C#                      | .NET
            //short -> [-2^16; +2^16]  | Int16
            //int   -> [-2^32; +2^32]  | Int32
            //long  -> [-2^64; +2^64]  | Int64

            //kasr son
            // C#                                     | .NET
            // float -> [-3.4*10^38; +3.4*10^38]      | Singel          
            // double -> [-1.7*10^308; +1.7*10^308]   | Double            
            // decimal -> [-7.9*10^28; +7.9*10^28]    | Decimal



            Console.WriteLine("Enter values:");
            Console.Write("First number: ");
            string firstUserValue = Console.ReadLine();            
            Console.Write("First number: ");
            string secondUserValue = Console.ReadLine();  


            Console.WriteLine("Convering values in progress...");
            decimal firstNumber = Convert.ToDecimal(firstUserValue);
            decimal secondNumber = Convert.ToDecimal(secondUserValue);

            Console.WriteLine("Here are your results: ");
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber+secondNumber}");
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber-secondNumber}");
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber*secondNumber}");
            Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber/secondNumber}");
            Console.WriteLine($"{firstNumber} % {secondNumber} = {firstNumber%secondNumber}");
        }
    }
}