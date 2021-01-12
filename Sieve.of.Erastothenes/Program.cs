using System;
using System.Collections.Generic;

namespace Sieve.of.Erastothenes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("chose your end number");
            int n = Convert.ToInt32(Console.ReadLine());
            //conver to "int"

            List<bool> prime = new List<bool>();

            for (int i = 0; i <= (n + 1); i++) 
            {
                prime.Add(true);
            }

            int p = 2;
            while (p * p <= n) 
            {
                // cheking if it's prime
                if (prime[p])
                {
                  
                    for (int y = (p * 2); y <= (n + 1); y += p)
                    {
                        prime[y] = false;
                    }

                }
                p += 1;
            }
            prime[0] = false;
            prime[1] = false;
            int count = 0;
            for (int j = 0; j <= (prime.Count - 1); j++) 
            {
                if (prime[j])
                {
                    count += 1;
                }
            }
            Console.WriteLine($"There are {count} primes up to {n}");

            Console.ReadKey();
        }
    }
}



        
        
            

