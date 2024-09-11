namespace sowmya5
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    internal class Program
    {
        public static void Main(string[] args)
        {
            string mobile, desktop;
            int n, sp, up, s, L, password;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---WELCOME to REALME---:");
            Console.WriteLine("   CHOOSE YOUR DEVICE   ");
            Console.WriteLine("1.MOBILE:");
            Console.WriteLine("2.DESKTOP:");
            Console.WriteLine("SELECT THE DEVICE:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter to passwordset:");
            sp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter to password login:");
            up = Convert.ToInt32(Console.ReadLine());
            {
                if (sp == up)
                {
                    Console.WriteLine("WELCOME to LOGGED in:");
                    Console.Write("PASSWORD:");
                    password = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.Write("Your password is wrong:");
                    int i = 5;
                    int b = 30;
                    while (sp != up)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("enter your re-enter password:");
                        Console.Write("enter the password:");
                        up = Convert.ToInt32(Console.ReadLine());
                        i--;
                        while (i == 0)
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("Try again after " + b + " seconds");
                            Thread.Sleep(1000);
                            Console.Clear();
                            b--;
                            if (b == 0)
                            {
                                i = 5;
                                b = 30;
                                Console.WriteLine("welcome to the page");
                            }
                        }
                    }


                }
            }
        }
    }
}
