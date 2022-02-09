using System;

namespace PrimeLib
{
    public class PrimeLib
    {
        public static bool CheckIfPrime(int n)
        {
            if (n < 0)
                throw new ArgumentException("liczba nie moze byc ujemna.");

            if (n == 0 || n == 1)
                return false;

            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
