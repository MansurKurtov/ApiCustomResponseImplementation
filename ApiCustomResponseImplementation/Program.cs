using System;

namespace ApiCustomResponseImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test case#1:");
            var testCase1 = GetStrings(-1);
            if (testCase1.IsSuccess)
                Console.WriteLine(testCase1.Result);
            else Console.WriteLine($"Error:{testCase1.Error.ErrorMessage}");

            Console.WriteLine("Test case#2:");
            var testCase2 = GetStrings(24);
            if (testCase2.IsSuccess)
                Console.WriteLine(testCase2.Result);
            else Console.WriteLine($"Error:{testCase2.Error.ErrorMessage}");

            Console.ReadKey();
        }

        public static ApiResponse<string> GetStrings(int i)
        {
            if (i < 0)
                return new ApiResponseError(-1, $"Integer value less then zero:{i})");

            return $"This number bigger then zero:{i}";
        }
    }
}
