using System;

namespace Palindrome_Challenge
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Program d = new Program();
            d.display();
        }

        public void isPalindrome(string txt)
        {
            int size = txt.Length;
            bool condition = true;
            for (int i = 0; i < size; i++)
            {
                if (txt[i] == txt[(size - 1) - i])
                {
                    condition = true;
                }
                else
                {
                    condition = false;
                    size = 0;
                }
                
            }
            Console.WriteLine($"Palindrome: {condition}, Length: {size}");
        }
        public void display()
        {
            Console.WriteLine("Let's begin");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit") break;
                Program p = new Program();
                p.isPalindrome(input);
            }
        }
    }
}
