using System;

namespace Prime.Services
{
    public class PrimeService
    {
		public bool IsPrime(int candidate)
		{
            //check if number is less than 1
			if(candidate < 2) return false;
            //check if the number is even
			if(candidate % 2 == 0) return (candidate == 2);
            //if number is odd then 
            int root = (int)Math.Floor(Math.Sqrt(candidate));
            for (int i = 3; i <= root; i+=2)
			{
				if(candidate % i == 0) return false;
			}
			return true;
		}
    }
}
