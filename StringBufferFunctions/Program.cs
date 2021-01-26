using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBufferFunctions12Jan
{
    class Program
    {
        static void BufferFunc()
        {
            while (true)
            {
                Console.WriteLine("\n\tMENU");
                Console.WriteLine("------------------------------");
                Console.WriteLine("Enter your choice of string builder function to proceed");
                Console.WriteLine("1.Append");
                Console.WriteLine("2.AppendLine");
                Console.WriteLine("3.Clear");
                Console.WriteLine("4.Replace");
                Console.WriteLine("5.CopyTo");
                Console.WriteLine("6.Capacity");
                Console.WriteLine("------------------------------\n");

                Console.WriteLine("Enter your choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Append                        
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Hello");
                        sb.Append("All");
                        sb.Append("Lets");
                        sb.Append("Talk");
                        Console.WriteLine(sb);
                        Console.ReadLine();
                        break;

                    case 2:
                        //AppendLine 
                        StringBuilder sb2 = new StringBuilder();
                        sb2.AppendLine("Hello ");
                        sb2.AppendLine("World!");
                        sb2.AppendLine("Hello C#");
                        Console.WriteLine(sb2);
                        Console.ReadLine();
                        break;

                    case 3:
                        //Replace
                        Console.WriteLine("Enter string");
                        string str1 = Console.ReadLine();
                        StringBuilder sb3 = new StringBuilder(str1);
                        sb3.Replace("a", "K");
                        Console.WriteLine(sb3);
                        Console.ReadLine();
                        break;

                    case 4:
                        //Clear
                        StringBuilder sb4 = new StringBuilder("Hello ");
                        sb4.Append("World");
                        Console.WriteLine($"Before Clear : {sb4}");
                        sb4.Clear();
                        Console.WriteLine($"After Clear : {sb4}");
                        Console.ReadLine();
                        break;

                    case 5:
                        //CopyTo
                        StringBuilder sb5 = new StringBuilder("Hello Good Morning");
                        char[] dest = new char[sb5.Length];

                        sb5.CopyTo(1, dest, 0, sb5.Length - 1);
                        //source index, index is 0 based
                        //destination
                        //destination index, index is 0 based
                        //count

                        // Displaying String 
                        Console.Write("The Copied String in dest variable is: ");
                        Console.WriteLine(dest);
                        break;

                    case 6:
                        //Capacity
                        StringBuilder sb6 = new StringBuilder("Hello Good Morning");
                        Console.WriteLine(sb6.Capacity); //default capacity is 16
                        Console.ReadLine();
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Enter again");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
                BufferFunc();
                Console.ReadLine();
        }
    }
}
