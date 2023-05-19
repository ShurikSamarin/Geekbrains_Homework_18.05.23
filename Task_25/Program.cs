// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number1 = Prompt("Input first number");
int number2 = Prompt("Input second number");
int power = 1;
for(int i=0; i<number2; i++)
{
    power = power*number1;
}
Console.WriteLine($"Number 1 to the power of Number 2 = {power}");