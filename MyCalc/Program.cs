using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace MyCalc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to demo calculator");
            string inputExpression = string.Empty;
            Regex re = new Regex(@"\D");
            while (true)
            {
                Console.WriteLine("Enter expession and hit enter");
                inputExpression = Console.ReadLine();
                Console.WriteLine("Thinking");
                Thread.Sleep(2000);
                char calcOperator= re.Matches(inputExpression)[0].Value[0];
                string[] operandStrings = inputExpression.Split(calcOperator);
                double leftOperand = double.Parse(operandStrings[0]);
                double rightOperand = double.Parse(operandStrings[1]);
                double result;
                switcht (calcOperator)
                {
                    case '+':
                        result = AddNumbers(leftOperand,rightOperand);
                        break;
                    case '-':
                        result = SubstructNumbers(leftOperand, rightOperand);
                        break;
                    case '*':
                        result = MultiplyNumbers(leftOperand, rightOperand);
                        break;
                    case '/':
                        result = DivideNumbers(leftOperand, rightOperand);
                        break;
                    default:
                        Console.WriteLine("Error in expression. Exiting....");
                        Console.ReadLine();
                        return;    
                }
                Console.WriteLine("Result: {0}",result);
            }
        }

        public static double AddNumbers(double leftOperand,double rightOperand)
        {
            return leftOperand + rightOperand;
        }

        public static double SubstructNumbers(double leftOperand, double rightOperand)
        {
            return leftOperand - rightOperand;
        }

        public static double MultiplyNumbers(double leftOperand, double rightOperand)
        {
            return leftOperand * rightOperand;
        }

        public static double DivideNumbers(double leftOperand, double rightOperand)
        {
            return leftOperand / rightOperand;
        }
    }
}
