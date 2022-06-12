using System;

namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            var mainUltima = "y";
            while (mainUltima == "y")
            {
                var isChoice = ChooseMethod();
                if (isChoice >= 1 && isChoice <= 5)
                {
                    var valueUltima = "y";
                    while (valueUltima == "y")
                    {
                        Console.WriteLine("Please, enter two value:");
                        var firstValue = 0.0;
                        var isFirstValue = double.TryParse(Console.ReadLine(), out firstValue);
                        var secondValue = 0.0;
                        var isSecondValue = double.TryParse(Console.ReadLine(), out secondValue);
                        if (isFirstValue && isSecondValue)
                        {
                            switch (isChoice)
                            {
                                case 1:
                                    AdditionMethod(firstValue, secondValue);
                                    break;
                                case 2:
                                    SubtractionMethod(firstValue, secondValue);
                                    break;
                                case 3:
                                    MultiplicationMethod(firstValue, secondValue);
                                    break;
                                case 4:
                                    DivisionMethod(firstValue, secondValue);
                                    break;
                                case 5:
                                    ExponentiationMethod(firstValue, secondValue);
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered invalid values.");
                            Console.WriteLine("Do you want to retry? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                            valueUltima = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine("Do you want to continue use this method? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                        valueUltima = Console.ReadLine();
                    }
                }
                if (isChoice == 6)
                {
                    var isValueUltima = "y";
                    while (isValueUltima == "y")
                    {
                        Console.WriteLine("Please, enter a positive value (MAX value = 170):");
                        double factorialValue = 0.0;
                        var isFactorialValue = double.TryParse(Console.ReadLine(), out factorialValue);
                        if (isFactorialValue && factorialValue >= 0)
                        {
                            switch (isChoice)
                            {
                                case 6:
                                    FactorialMethod(factorialValue);
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered invalid values. Factorial calculation only works for positive values.");
                            Console.WriteLine("Do you want to retry? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                            isValueUltima = Console.ReadLine();
                            continue;
                        }
                        Console.WriteLine("Do you want to continue use this method? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                        isValueUltima = Console.ReadLine();
                    }
                }
                Console.WriteLine("Do you want to continue use a calculator? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                mainUltima = Console.ReadLine();
                if (mainUltima != "y")
                {
                    Console.WriteLine("Have a good day!");
                }
            }
        }

        static double AdditionMethod(double firstValue, double secondValue)

        {
            var additionResult = 0.0;
            additionResult = firstValue + secondValue;
            Console.WriteLine($"Addition result: {firstValue} + {secondValue} = {additionResult}.");
            return additionResult;
        }

        static double SubtractionMethod(double firstValue, double secondValue)
        {
            var subtractionResult = 0.0;
            subtractionResult = firstValue - secondValue;
            Console.WriteLine($"Addition result: {firstValue} - {secondValue} = {subtractionResult}.");
            return subtractionResult;
        }

        static double MultiplicationMethod(double firstValue, double secondValue)
        {
            var multiplicationResult = 0.0;
            multiplicationResult = firstValue * secondValue;
            Console.WriteLine($"Addition result: {firstValue} * {secondValue} = {multiplicationResult}.");
            return multiplicationResult;
        }

        static double DivisionMethod(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                Console.WriteLine("Division by 0 is not possible");
                return 0;
            }
            var divisionResult = 0.0;
            divisionResult = firstValue / secondValue;
            Console.WriteLine($"Addition result: {firstValue} / {secondValue} = {divisionResult}.");
            return divisionResult;
        }

        static double ExponentiationMethod(double firstValue, double secondValue)
        {
            var exponentiationResult = 0.0;
            exponentiationResult = Math.Pow(firstValue, secondValue);
            Console.WriteLine($"Addition result: {firstValue} ^ {secondValue} = {exponentiationResult}.");
            return exponentiationResult;
        }

        static double FactorialMethod(double firstValue)
        {
            double factorialResult = 1.0;
            for (double i = 2; i <= firstValue; i++)
            {
                factorialResult = factorialResult * i;
            }
            Console.WriteLine($"Factorial result for {firstValue} = {factorialResult}.");
            return factorialResult;
        }

        static uint ChooseMethod()
        {
            var chooseUltima = "y";
            while (chooseUltima == "y")
            {
                Console.WriteLine("Please, choose a calculation method:\n 1) Addition (+) \n 2) Subtraction (-) \n 3) Multiplication (*) \n 4) Division (/) \n 5) Exponentiation (^) \n 6) Factorial (n!)");
                uint choice = 0;
                var isChoice = uint.TryParse(Console.ReadLine(), out choice);
                if (isChoice && choice > 0 && choice <= 6)
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Cool! You selected Addition Method.");
                            break;
                        case 2:
                            Console.WriteLine("Cool! You selected Subtraction Method.");
                            break;
                        case 3:
                            Console.WriteLine("Cool! You selected Multiplication Method.");
                            break;
                        case 4:
                            Console.WriteLine("Cool! You selected Division Method.");
                            break;
                        case 5:
                            Console.WriteLine("Cool! You selected Exponentiation Method.");
                            break;
                        case 6:
                            Console.WriteLine("Cool! You selected Factorial Method.");
                            break;
                    }
                    return choice;
                }
                Console.WriteLine("You entered invalid values.");
                Console.WriteLine("Do you want to retry? \n 1) Press 'y' button if - YES \n 2) Press anything button if - NO");
                chooseUltima = Console.ReadLine();
                if (chooseUltima != "y")
                {
                    Console.WriteLine("Your choice - NO.");
                }
            }
            return 0;
        }
    }
}

