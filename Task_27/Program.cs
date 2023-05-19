// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
int number = Prompt("Input number");
int sum = 0;
while (number !=0){
    sum = sum + number%10;//получаем последний разряд числа и добавляем его к сумме
    number = number/10;//убираем последний разряд из числа
}
Console.WriteLine($"Sum of digits = {sum}");
