using System;

namespace GreedyAlgo
{
    class Solution
    {
  

        public int solution(String s, int[] c)
        {
            int mx = 0;
            int result = 0;
            int i = 0;
            char prev = '\\';
            foreach (char x in s.ToCharArray())
            {
                if ((prev != x))
                {
                    result = (result - mx);
                    mx = 0;
                }

                mx = Math.Max(c[i], mx);
                prev = x;
                result = (result + c[i++]);
            }

            result = (result - mx);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine((new Solution().solution("abccbd", new int[] {
                        0,
                        1,
                        2,
                        3,
                        4,
                        5})));
            Console.WriteLine((new Solution().solution("aabbcc", new int[] {
                        1,
                        2,
                        1,
                        2, 
                        1,
                        2})));
            Console.WriteLine((new Solution().solution("aaaa", new int[] {
                        3,
                        4,
                        5,
                        6})));
            Console.WriteLine((new Solution().solution("ababa", new int[] {
                        10,
                        5,
                        10,
                        6,
                        10})));
        }
    }
}
