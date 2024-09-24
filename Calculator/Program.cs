Console.WriteLine("Type in the first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result;

Console.WriteLine("Choose from the following options");
Console.WriteLine("1 - Add");
Console.WriteLine("2 - Subtract");
Console.WriteLine("3 - Divide");
Console.WriteLine("4 - Multiply");

int choice = Convert.ToInt32(Console.ReadLine());
if (choice == 1)
{
    result = firstNumber + secondNumber;
    Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
}
else if (choice == 2)
{
    result =firstNumber - secondNumber;
    Console.WriteLine("{0} - {1} = {2}", firstNumber, secondNumber, result);
}
else if (choice == 3)
{
    result = firstNumber / secondNumber;
    Console.WriteLine("{0} / {1} = {2}", firstNumber, secondNumber, result);
    
}
else if (choice == 4)
{
    result = firstNumber * secondNumber;
    Console.WriteLine("{0} * {1} = {2}", firstNumber, secondNumber, result);
}
else
{
    Console.WriteLine("Invalid Number");
}

