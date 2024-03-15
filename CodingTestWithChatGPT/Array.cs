namespace CodingTestWithChatGPT
{
    //24.3.15

    internal class Array
    {
        public static int[] numbers = { 3, 9, 4, 1, 10, 50, 20, 2 };
        static void Main(string[] args)
        {
            int max = GetMaxNum();

            Console.WriteLine($"최대값은 : {max}");
        }

        public static int GetMaxNum()
        {
            int maxNum = numbers[0];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maxNum)
                {
                    maxNum = numbers[i];
                }
            }

            return maxNum;
        }
    }
}

