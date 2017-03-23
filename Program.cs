using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumebr = 0;
            double secondNumber = 0;
            char? Symbol = null;
        LAP:
            Console.Write("请输入第一个数:");
            try
            {
                firstNumebr = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误!请重新输入!");
                goto LAP;
            }
            Console.Write("请输入第二个数:"); try
            {
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("输入错误!请重新输入!");
                goto LAP;
            }
            Console.Write("请选择计算类型:");
            try
            {
                Symbol = Convert.ToChar(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("运算符错误!请重新输入!");
                goto LAP;
            }
            switch (Symbol)
            {
                case '+': Add add = new Add(firstNumebr, secondNumber); Console.Write($"{add}\n\n"); goto LAP;
                case '-': Subduction subduction = new Subduction(firstNumebr, secondNumber); Console.Write($"{subduction}\n\n"); goto LAP;
                case '*': Multiplication multiplication = new Multiplication(firstNumebr, secondNumber); Console.Write($"{multiplication}\n\n"); goto LAP;
                case '/': Division division = new Division(firstNumebr, secondNumber); Console.Write($"{division}\n\n"); goto LAP;
            }
        }
    }
    class Add
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double sum = 0;

        public Add(double a, double b)
        {
            this.firstNumber = a;
            this.secondNumber = b;

            sum = this.firstNumber + this.secondNumber;
        }
        public override string ToString()
        {
            string Data = $"结果为:{this.sum}";
            return Data;
        }
    }
    class Subduction
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double sum = 0;

        public Subduction(double a, double b)
        {
            this.firstNumber = a;
            this.secondNumber = b;

            sum = this.firstNumber - this.secondNumber;
        }
        public override string ToString()
        {
            string Data = $"结果为:{this.sum}";
            return Data;
        }

    }
    class Multiplication
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double sum = 0;

        public Multiplication(double a, double b)
        {
            this.firstNumber = a;
            this.secondNumber = b;

            sum = this.firstNumber * this.secondNumber;
        }
        public override string ToString()
        {
            string Data = $"结果为:{this.sum}";
            return Data;
        }

    }
    class Division
    {
        private double firstNumber = 0;
        private double secondNumber = 0;
        private double sum = 0;

        public Division(double a, double b)
        {
            this.firstNumber = a;
            this.secondNumber = b;

            sum = this.firstNumber / this.secondNumber;
        }
        public override string ToString()
        {
            string Data = $"结果为:{this.sum}";
            return Data;
        }

    }
}