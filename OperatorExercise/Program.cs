﻿namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int divide = a / b;
            int product  = a * b;
            int modbus = a % b;
            Console.WriteLine($"{a}/{b} is = {divide} remainder {modbus}.");
        }
    }
}
