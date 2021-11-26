using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку для проверки");
            String s = Console.ReadLine();// создаем строку
            char[] array = s.ToCharArray();//делим строку на массив символов
            List<char> list = new List<char>();//создаем список символов
            List<char> list2 = new List<char>();//создаем список для нужных элементов
            list.AddRange(array);//добавляем массив элементов в первый список

            for (int i=0;i<list.Count;i++)//епребором оставляем только нужные символы
            if (list [i]=='{')
            {
                    list2.Add('{');
            }
            else if (list [i] == '}')
            {
                list2.Add('}');
            }
            else if (list[i] == '[')
            {
                list2.Add('[');
            }
            else if (list[i] == ']')
            {
                list2.Add(']');
            }
            else if (list[i] == ')')
            {
                list2.Add(')');
            }
            else if (list[i] == '(')
            {
                list2.Add('(');
            }
            Console.WriteLine("Список без лишних символов");
            foreach (char i in list2)//для проверки правилньости выводим на экран
            {
                Console.WriteLine(i);
            }
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < list2.Count; i++)
                if (list2[i] == '{')
                {
                    stack.Push('{');
                }
                else if (list2[i] == '}')
                {
                    stack.Pop();
                }
            else if (list2[i] == '[')
            {
                stack.Push('[');
            }
            else if (list2[i] == ']')
            {
                stack.Pop();
            }
                else if (list2[i] == '{')
                {
                    stack.Push('{');
                }
                else if (list2[i] == '}')
                {
                    stack.Pop();
                }

            Console.WriteLine("Итоговый список");
            foreach (char i in stack)//для проверки правилньости выводим на экран
            {
                Console.WriteLine(i);
            }
            
            if (stack.Count == 0)
            {
                Console.WriteLine("скобки расставлены верно");
            }
            else
            {
                Console.WriteLine("скобки расставлены не верно");
            }




            Console.ReadKey();
        }
    }
}
