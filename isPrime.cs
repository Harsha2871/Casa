using System;
public class Casa
{
    public static bool IsPrime(int n)
    {
        //if num is 1 or 0, neither prime or composite case.
        if (n <= 1)
            return false;
        for (int i=2; i <=Math.Sqrt(n); i++)
          if (n %i == 0) 
            return false;
        return true;
    }
    public static void Main()
    {
    
        for(;;){
	        Console.Write("Enter a number : ");
            int n= Convert.ToInt32(Console.ReadLine());
            if (IsPrime(n))
                Console.WriteLine(n+" is a prime number");
            else
                Console.WriteLine(n+" is not a prime number");
        }
    }
}
