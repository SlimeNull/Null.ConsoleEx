using Null.ConsoleEx.Properties;
using System;

namespace Null.ConsoleEx
{
    public static class ConsoleEx
    {
        static byte[] Lengths = Resources.Lengths;
        public static bool IsWideDisplayChar(char c)
        {
            int index = c;
            return (Lengths[index / 8] & (1 << (index % 8))) != 0;
        }
        public static int GetCharDisplayLength(char c)
        {
            int index = c;
            bool wideChar = (Lengths[index / 8] & (1 << (index % 8))) != 0;

            return wideChar ? 2 : 1;
        }
        public static int GetStringDisplayLength(string str)
        {
            int total = 0;
            foreach (char c in str)
            {
                int i = c;
                total += (Lengths[i / 8] & (1 << (i % 8))) != 0 ? 2 : 1;
            }
            return total;
        }
    }
    public static class ConsoleExS
    {
        static byte[] Lengths = Resources.Lengths;
        public static bool IsWideDisplayChar(char c)
        {
            int index = c;
            return (Lengths[index / 8] & (1 << (index % 8))) != 0;
        }
        public static int GetCharDisplayLength(char c)
        {
            int index = c;
            bool wideChar = (Lengths[index / 8] & (1 << (index % 8))) != 0;

            return wideChar ? 2 : 1;
        }
        public static int GetStringDisplayLength(string str)
        {
            if (str == null)
                throw new ArgumentNullException("str");

            int total = 0;
            foreach (char c in str)
            {
                int i = c;
                total += (Lengths[i / 8] & (1 << (i % 8))) != 0 ? 2 : 1;
            }
            return total;
        }
    }
}
