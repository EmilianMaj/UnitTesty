using System;
using System.Linq;

namespace SimpleBank
{
    internal class Generator : IGenerator
    {
        public Account CreateAccount()
        {
            string pin = GenerateNewPin();
            string id = GenerateNewID("400000", 16);
            return new Account(id, pin);
        }

        private string GenerateNewID(string bin, int length)
        {
            Random random = new Random();

            int[] array = new int[length];
            int[] array2 = bin.Select((char p) => p - 48).ToArray();
            for (int i = 0; i < array2.Length; i++)
            {
                array[i] = array2[i];
            }

            for (int j = bin.Length; j < length - 1; j++)
            {
                int num = array[j] = random.Next(0, 10);
            }

            array[length - 1] = GenerateCheckDigit(array[..(length - 1)]);

            return string.Join(null, array);
        }

        private string GenerateNewPin()
        {
            Random random = new Random();

            return random.Next(0, 9).ToString() +
                   random.Next(0, 9).ToString() +
                   random.Next(0, 9).ToString() +
                   random.Next(0, 9).ToString();
        }

        private int GenerateCheckDigit(int[] digits)
        {
            var sum = CalculateSum(digits);

            var lastDigit = sum * 9 % 10;
            return lastDigit;
        }

        private int CalculateSum(int[] digits, int bitShift = 0)
        {
            var sum = digits.Reverse()
                                .Select((digit, i) =>
                                        (i + bitShift) % 2 == 0
                                        ? digit * 2 > 9 ? digit * 2 - 9 : digit * 2
                                        : digit)
                                .Sum();
            return sum;
        }
    }
}
