CalculatorMenu();
static void CalculatorMenu()
{
    Console.Clear();
    Console.WriteLine("Calculator Menu");
    Console.WriteLine("1) Add");
    Console.WriteLine("2) Subtract");
    Console.WriteLine("3) Multiply");
    Console.WriteLine("4) Divide");
    Console.WriteLine("5) Exit");
    Console.WriteLine("Enter your selection: ");
    string? selection = Console.ReadLine();
    switch (selection)
    {
        case "1":
            Sum();
            break;
        case "2":
            Subtract();
            break;
        case "3":
            Multiply();
            break;
        case "4":
            Divide();
            break;
        case "5":
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            Console.ReadKey();
            CalculatorMenu();
            break;
    }
}

static void Sum()
{
    Console.Clear();
    Console.WriteLine("Enter the first number: ");
    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"The sum of {firstNumber} and {secondNumber} is {firstNumber + secondNumber}");
    Console.ReadKey();
    CalculatorMenu();
}

static void Subtract()
{
    Console.Clear();
    Console.WriteLine("Enter the first number: ");
    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"The difference of {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");
    Console.ReadKey();
    CalculatorMenu();
}

static void Multiply()
{
    Console.Clear();
    Console.WriteLine("Enter the first number: ");
    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"The product of {firstNumber} and {secondNumber} is {firstNumber * secondNumber}");
    Console.ReadKey();
    CalculatorMenu();
}

static void Divide()
{
    Console.Clear();
    Console.WriteLine("Enter the first number: ");
    decimal firstNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine("Enter the second number: ");
    decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
    Console.WriteLine($"The quotient of {firstNumber} and {secondNumber} is {firstNumber / secondNumber}");
    Console.ReadKey();
    CalculatorMenu();
}
