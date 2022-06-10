// Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int prompt(string message)
{
    Console.Write(message);
    string number = Console.ReadLine();
    int numberInt = int.Parse(number);
    return numberInt;
}

int numberInt = prompt("Введите трехзначное число : ");
int i=0, number2=0;
if (numberInt<100 || numberInt>999)
    {
        Console.WriteLine("Вы ввели которое не является трехзначным и неподходит под условию.");
        return;
    }
while (i <2)
{
    number2 = numberInt%10;
    numberInt = numberInt/10;
    i++;
}
Console.WriteLine($"Вторая цифра в числе = {number2}");
