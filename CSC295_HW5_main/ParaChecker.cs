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
        // Method to create a stack from the input string, where each character of the string is pushed onto the stack
        public static Stack<char> createStack(string inputString)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < inputString.Length; i++)
            {
                // Push each character of the string onto the stack
                stack.Push(inputString[i]);
            }
            return stack;
        }

        // Method to check if the input string has balanced parentheses
        public static bool IsBalanced(string line)
        {
            // Create a stack from the input string using the createStack method
            Stack<char> stack = createStack(line);

            // Boolean variables to track if each type of parenthesis is balanced
            bool isCurly = true;
            bool isBracket = true;
            bool isPara = true;

            // Iterate through the stack until it is empty
            while (stack.Any())
            {
                char value = stack.Pop(); // Pop the top character from the stack

                // Check if the character is a curly brace
                if (value == '}' || value == '{')
                {
                    // Toggle the isCurly boolean value
                    isCurly = !isCurly;
                }
                // Check if the character is a square bracket
                else if (value == ']' || value == '[')
                {
                    // Toggle the isBracket boolean value
                    isBracket = !isBracket;
                }
                // Check if the character is a parenthesis
                else if (value == ')' || value == '(')
                {
                    // Toggle the isPara boolean value
                    isPara = !isPara;
                }
                else
                {
                    continue; // If the character is not a parenthesis, continue to the next iteration
                }
            }
            // If all boolean values are true, the string is balanced; otherwise, it is not
            if (isCurly && isBracket && isPara) return true;
            else return false;
        }
    }
}
