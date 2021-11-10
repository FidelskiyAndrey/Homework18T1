using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework18T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скобки");
            var str = Console.ReadLine();
            //string str = "([]{})[]";

            var result = IsGoodBrackets(str);

            if(result)
                Console.WriteLine("Со скобками все ОК.");
            else
                Console.WriteLine("Нет закрывающих элементов");


            Console.ReadKey();
        }

        static bool IsGoodBrackets(string str)
        {
            try
            {
                Stack<char> stack = new Stack<char>();

                foreach (var ch in str)
                {
                    switch (ch)
                    {
                        case '(':
                            stack.Push(')');
                            break;
                        case '[':
                            stack.Push(']');
                            break;
                        case '{':
                            stack.Push('}');
                            break;
                        default:
                            var pop_ch = stack.Pop();
                            if (pop_ch != ch)
                            {
                                throw new Exception("Неправильно расставлены скобки");
                            }
                            break;
                    }
                }

                if (stack.Count > 0)
                {
                    throw new Exception("Неправильно расставлены скобки");
                }

                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
