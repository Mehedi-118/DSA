using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_To_PostFix_PreFix
{
    internal class Program
    {
        private static int check_Precedence(char c)
        {

            switch (c)
            {
                case '^':
                    return 4;
                case '*':
                case '/':
                    return 3;
                case '+':
                case '-':
                    return 2;
            }
            return -1;
        }
        private static string Evaluate_PostFix_Expression(string expression)
        {
            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            foreach (char c in expression)
            {
                //Console.WriteLine(c);
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        sb.Append(stack.Pop());
                    if (stack.Peek() != '(')
                        Console.WriteLine("Invalid Expression");
                    else

                        stack.Pop();
                }
                else
                {                   
                    while (stack.Count > 0 && check_Precedence(c) <= check_Precedence(stack.Peek()))
                    
                        sb.Append(stack.Pop());
                    
                    stack.Push(c);
                }

            }
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());

            }
            return sb.ToString();
            // Console.ReadLine();
        }

        private static string Evaluate_PreFix_Expression(string expression)
        {
            
            StringBuilder sb1 = new StringBuilder(new String(expression.Reverse().ToArray()));
            StringBuilder sb = new StringBuilder();
            Stack<char> stack = new Stack<char>();
            Console.WriteLine(sb);
            for (int i=0;i<sb1.Length;i++)
            {
                if (sb1[i] == '(')
                    sb1[i] = ')';
                else if (sb1[i] == ')')
                    sb1[i] = '(';

            }
            Console.WriteLine(sb1);
           
            foreach (char c in sb1.ToString())
            {
                //Console.WriteLine(c);
                if (char.IsLetterOrDigit(c))
                {
                    sb.Append(c);
                }
                else if (c == '(')
                {
                    stack.Push(c);
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                        sb.Append(stack.Pop());
                    if (stack.Peek() != '(')
                        Console.WriteLine("Invalid Expression");
                    else

                        stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && check_Precedence(c) <= check_Precedence(stack.Peek()))

                        sb.Append(stack.Pop());

                    stack.Push(c);
                }

            }
            while (stack.Count > 0)
            {
                sb.Append(stack.Pop());

            }
            return new string(sb.ToString().Reverse().ToArray());
            // Console.ReadLine();
        }


        static void Main(string[] args)
        {
            string expression=Console.ReadLine();
            string result = Evaluate_PostFix_Expression(expression);
            string result1 = Evaluate_PreFix_Expression(expression);
            Console.WriteLine("Postfix Expression of Given Infix Expression :{0}",result);
            Console.WriteLine("Pretfix Expression of Given Infix Expression :{0}",result1);
            Console.WriteLine(result1);
            Console.ReadLine();
        }

        
      
       
    }
}
