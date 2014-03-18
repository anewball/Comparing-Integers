using System;

namespace Multiple
{
   class Program
   {
     public static void Main(string[] args)
     {				
       Console.Write("Please enter number1: ");
       int number1 = int.Parse(Console.ReadLine());
			
       Console.Write("\nPlease enter number2: ");
       int number2 = int.Parse(Console.ReadLine());
			
       Console.WriteLine();
			
       if (number1 > number2)     
           Console.WriteLine("{0} is larger", number1);
       else if(number2 > number1) 
           Console.WriteLine("{0} is larger", number2);
       else                       
           Console.WriteLine("These numbers are equal");
				
       Console.ReadLine();
     }
   }
}
