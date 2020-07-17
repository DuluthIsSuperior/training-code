using System;

namespace Calculator {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Welcome to out Basic Calculator");

      bool stay = true;
      do {
        Console.WriteLine("Menu");
        Console.WriteLine("Press 1 for addition");
        Console.WriteLine("Press 2 for Subtraction");
        Console.WriteLine("Press 3 for Multiplication");
        Console.WriteLine("Press 4 for Division");
        Console.WriteLine("Press 5 or any other key to exit");

        string choice = Console.ReadLine();

        switch (choice) {
          case "1":
            double input1 = double.Parse(Console.ReadLine());
            double input2;
            double.TryParse(Console.ReadLine(), out input2);
            Add(input1, input2);
            break;
          case "2":
            double input01;
            double input02;

            if (double.TryParse(Console.ReadLine(), out input01)) {
              Console.WriteLine("valid");
            } else {
              Console.WriteLine("not valid");
            }

            if (double.TryParse(Console.ReadLine(), out input02)) {
              Console.WriteLine("valid");
            } else {
              Console.WriteLine("not valid");
            }

            Subtract(input01, input02);
            break;
          default:
            stay = false;
            break;
        }
      } while (stay);
    }

    static void Add(double operand1, double operand2) {
      double result = operand1 + operand2;
      Console.WriteLine($"Your answer is {result}");  
    }

    static void Subtract(double operand1, double operand2) {
      double result = operand1 - operand2;
      Console.WriteLine($"Your answer is {result}"); 
    }
  }
}
