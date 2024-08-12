using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295_HW5
{
    public class ParaChecker
    {
        
        public static Stack<char> createStack(string inputString)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                stack.Push(inputString[i]);
            }
            return stack;
        }

        
        public static bool IsBalanced(string line)
        {
            Stack<char> stack = createStack(line);
            bool isCurly = true;
            bool isBracket = true;
            bool isPara = true;
            while (stack.Any())
            {
                char value = stack.Pop();
                if (value == '}' || value == '{')
                {
                    isCurly = !isCurly;
                }
                else if (value == ']' || value == '[')
                {
                    isBracket = !isBracket;
                }
                else if (value == ')' || value == '(')
                {
                    isPara = !isPara;
                }
                else
                {
                    continue;
                }
            }
            if (isCurly && isBracket && isPara) return true;
            else return false;
        }
    }
}
