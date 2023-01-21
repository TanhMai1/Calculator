do
{
    double firstNumber = 0;
    double secondNumber = 0;
    double result = 0;

    Console.WriteLine("Welcome To The Calculator");
    Console.WriteLine("--------------------------");

    Console.WriteLine("Enter first number: ");
    firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter second number: ");
    secondNumber = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What operation would you like to do? ");
    Console.WriteLine("+: Addition");
    Console.WriteLine("-: Subtraction");
    Console.WriteLine("*: Multiplication");
    Console.WriteLine("/: Division");

    switch (Console.ReadLine())
    {
        case "+":
            result = firstNumber + secondNumber;
            Console.WriteLine($"Result is {firstNumber} + {secondNumber} = {result}");
            break;
        case "-":
            result = firstNumber - secondNumber;
            Console.WriteLine($"Result is {firstNumber} - {secondNumber} = {result}");
            break;
        case "*":
            result = firstNumber * secondNumber;
            Console.WriteLine($"Result is {firstNumber} - {secondNumber} = {result}");
            break;
        case "/":
            result = firstNumber / secondNumber;
            Console.WriteLine($"Result is {firstNumber} / {secondNumber} = {result}");
            break;
    }
    Console.WriteLine("Woud you like to restart? Y/N?");
} while (Console.ReadLine().ToUpper()=="Y")
