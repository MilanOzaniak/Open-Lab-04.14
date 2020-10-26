using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            var longest = GetLongest(strings);
            for (int i = 0; i < longest + 4; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();

            foreach (string str in strings)
            {
                string line = $"* {str} ";
                for (int i = 0; i < longest - str.Length; i++)
                {
                    line += " ";
                }
                Console.WriteLine(line + "*");
            }

            for (int i = 0; i < longest + 4; i++)
            {
                Console.Write("*");

            }
            Console.WriteLine();
        }

        public int GetLongest(string[] strings)
        {
            string temp = "";
            int num = 0;
            foreach (string str in strings)
            {
                if (str.Length > num)
                {
                    temp = str;
                    num = str.Length;
                }
            }
            return temp.Length;
        }
    }
}