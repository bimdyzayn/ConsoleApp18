using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {


            bool d = true;
            do
            {
                Console.WriteLine("Введите строку");
                string str = Console.ReadLine();
                int k = 0, k1 = 0, k3 = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if (str[i] == '(')
                        k++;

                    if (str[i] == ')')
                        k--;

                    if (str[i] == '[')
                        k1++;

                    if (str[i] == ']')
                        k1--;

                    if (str[i] == '{')
                        k3++;

                    if (str[i] == '}')
                        k3--;
                }
                if ((k == 0 && str.Length != 0) && (k1 == 0 && str.Length != 0) && (k3 == 0 && str.Length != 0))
                {
                    Console.WriteLine("Баланс скобок соблюден");
                }
                else Console.WriteLine("Баланс скобок несоблюден");

     
            } while (d == true);
        }
    


        
    }
}
