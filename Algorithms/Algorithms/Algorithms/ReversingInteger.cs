namespace Algorithms.Algorithms
{
    public static class ReversingInteger
    {
        public static int Reverse(int x)
        {
            int result = 0;
            while (x != 0)
            {
                int mod = x % 10;
                int newResult = result * 10 + mod;
                if ((newResult - mod) / 10 != result)
                    return 0;
                result = newResult;
                x /= 10;
            }
            return result;
        }
    }
}
