using System;

namespace cheque_writer
{
    class Program
    {
        static string my_num;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter your number: ");
                my_num = Console.ReadLine();
                int l = my_num.Length;
                if (my_num.Contains('.'))
                {
                    Console.WriteLine($"your num: {my_num}");
                    string myNum_float = my_num.Substring((my_num.IndexOf('.')+1), 2);
                    my_num = my_num.Substring(0, my_num.IndexOf('.'));
                    Console.WriteLine(my_num);
                    Console.WriteLine(myNum_float);
                   Console.WriteLine( Rial.NumToArray(my_num) + " dollar and " + Rial.NumToArray(myNum_float) + " cent ");
                }
                else
                {
                    if (my_num == "0")
                    {
                        Console.WriteLine($"Your number is: {my_num}");
                        Console.WriteLine("sefr");
                    }
                    else
                    {
                        my_num = my_num.TrimStart('0');
                        Console.WriteLine($"Your number is: {my_num}");
                       Console.WriteLine( Rial.NumToArray(my_num));
                    }
                }
         
            }



        }
    }

}