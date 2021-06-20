using System;
public class Casa
{
    public static bool isPrime(int num)
    {
        //if num is 1 or 0, neither prime or composite case.
        if (num <= 1)
            return false;
        for (int i=2; i <=Math.Sqrt(num); i++)
          if (num %i == 0) 
            return false;
        return true;
    }
    public static void Main()
    {
	  Console.Write("Enter a number : ");
      int n= Convert.ToInt32(Console.ReadLine());
        if (isPrime(n))
          Console.WriteLine(n+" is a prime number");
        else
          Console.WriteLine(n+" is not a prime number");
    }
}
