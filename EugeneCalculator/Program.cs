using System;
namespace Calculator

{
    class Program
    {
        static void Main(string[] args)
        {
            char ultima = 'y';
            while (ultima == 'y')
            {
                Console.WriteLine("Hello! Choose a calculation method:\n 1) Addition (+) \n 2) Subtraction (-) \n 3) Multiplication (*) \n 4) Division (/) \n 5) Modulo (%)");
                ChooseMethod();
                Console.WriteLine("Do you want to continue use a calculator? \n 1) Press 'y' if YES \n 2) Press 'n' if NO");
                ultima = Convert.ToChar(Console.ReadLine());
            }

        }
        static int AdditionMethod(int firstValue, int secondValue)
        {
            return firstValue + secondValue;
        }
        static int SubtractionMethod(int firstValue, int secondValue)
        {
            return firstValue - secondValue;
        }
        static int MultiplicationMethod(int firstValue, int secondValue)
        {
            return firstValue * secondValue;
        }
        static float DivisionMethod(int firstValue, int secondValue)
        {
            float result = (float)firstValue / (float)secondValue;
            return result;
        }
        static int ModuloMethod(int firstValue, int secondValue)
        {
            return firstValue % secondValue;
        }

        static uint ChooseMethod()
        {
            uint choice = 0;
            var isChoice = uint.TryParse(Console.ReadLine(), out choice);
            if (isChoice && choice > 0 && choice <= 5)
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Cool! You selected Addition Method.");
                        Console.WriteLine("Please, enter two integer:");
                        int firstAdditionValue = Convert.ToInt32(Console.ReadLine());
                        int secondAdditionValue = Convert.ToInt32(Console.ReadLine());
                        int additionResult = AdditionMethod(firstAdditionValue, secondAdditionValue);
                        Console.WriteLine($"Addition result: {firstAdditionValue} + {secondAdditionValue} = {additionResult}.");
                        break;
                    case 2:
                        Console.WriteLine("Cool! You selected Subtraction Method.");
                        Console.WriteLine("Please, enter two integer:");
                        int firstSubtractionValue = Convert.ToInt32(Console.ReadLine());
                        int secondSubtractionValue = Convert.ToInt32(Console.ReadLine());
                        int subtractionResult = SubtractionMethod(firstSubtractionValue, secondSubtractionValue);
                        Console.WriteLine($"Subtraction result: {firstSubtractionValue} - {secondSubtractionValue} = {subtractionResult}.");
                        break;
                    case 3:
                        Console.WriteLine("Cool! You selected Multiplication Method.");
                        Console.WriteLine("Please, enter two integer:");
                        int firstMultiplicationValue = Convert.ToInt32(Console.ReadLine());
                        int secondMultiplicationValue = Convert.ToInt32(Console.ReadLine());
                        int multiplicationResult = MultiplicationMethod(firstMultiplicationValue, secondMultiplicationValue);
                        Console.WriteLine($"Multiplication result: {firstMultiplicationValue} * {secondMultiplicationValue} = {multiplicationResult}.");
                        break;
                    case 4:
                        Console.WriteLine("Cool! You selected Division Method.");
                        Console.WriteLine("Please, enter two integer:");
                        int firstDivisionValue = Convert.ToInt32(Console.ReadLine());
                        int secondDivisionValue = Convert.ToInt32(Console.ReadLine());

                        float divisionResult = DivisionMethod(firstDivisionValue, secondDivisionValue);
                        Console.WriteLine($"Division result: {firstDivisionValue} / {secondDivisionValue} = {divisionResult}.");
                        break;
                    case 5:
                        Console.WriteLine("Cool! You selected Modulo Method.");
                        Console.WriteLine("Please, enter two integer:");
                        int firstModuloValue = Convert.ToInt32(Console.ReadLine());
                        int secondModuloValue = Convert.ToInt32(Console.ReadLine());
                        int moduloResult = ModuloMethod(firstModuloValue, secondModuloValue);
                        Console.WriteLine($"Modulo result: {firstModuloValue} % {secondModuloValue} = {moduloResult}.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please, select correctly choice and try again");
            }
            return choice;
        }
    }
}
