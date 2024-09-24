Console.WriteLine("Type in the first number followed by the enter key");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Type in the second number followed by the enter key");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = firstNumber + secondNumber;

Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, result);
