namespace Algorithms.Algorithms
{
    public static class IsPalindromeAlgorithm
    {
        public static bool isPalindrome(int x)
        {
            //1221==>12
            if (x < 0 || (x !=0 && x % 10 == 0)) return false;
            int secondHalfReverse = 0;
            while (x > secondHalfReverse)
            {
                secondHalfReverse = secondHalfReverse * 10 + x % 10;
                x /= 10;
            }
            return (x == secondHalfReverse || x == secondHalfReverse / 10);
        }
    }
}
