//Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

Console.WriteLine("Генерируем случайное трехзначое число");
int x = new Random().Next(100,1000);
Console.WriteLine($"Случайное трехзначное число = {x}");
int[] array = new int[3];
int index = array.Length - 1;
    while (index >= 0)
        {
            array[index] = x%10;
            x = x/10;
            index--;
        }

    
Console.Write($"Число без второй цифры = {array[0]}{array[2]}");
