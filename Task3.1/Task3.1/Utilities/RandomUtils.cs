namespace Task3._1.Utilities
{
    using System;
    using System.Text;

    public static class RandomUtils
    {
        private static readonly Random random = new Random();
        private static readonly int minLength = 8;
        private static readonly int maxLength = 12;
        private static readonly string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        public static string getRandomText()
        {
            int length = random.Next(minLength, maxLength + 1);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                sb.Append(characters[random.Next(characters.Length)]);
            }
            return sb.ToString();
        }
    }
}
