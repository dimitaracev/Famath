using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Famath
{
    class MathGenerator
    {
        int current_answer;
        Random rand;
        static char[] operations = new char[] { '+', '-', '*' };
        public MathGenerator()
        {
            rand = new Random();
            current_answer = 0;
        }

        public String GenerateExpression(int num_range, int multiplier)
        {

            int left = rand.Next(1, num_range * multiplier);
            int right = rand.Next(1, num_range * multiplier);
            char op = operations[rand.Next(0, operations.Length)];

            switch(op)
            {
                case '+':
                    current_answer = left + right;
                    break;
                case '-':
                    current_answer = left - right;
                    break;
                case '*':
                    current_answer = left * right;
                    break;
            }

            return left.ToString() + " " + op + " " + right.ToString();
        }

        public int GetAnswer()
        {
            return current_answer;
        }
    }
}
