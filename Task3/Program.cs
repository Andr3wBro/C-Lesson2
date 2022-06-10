// Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите трехзначное число : ");
string number = Console.ReadLine();
int numberInt = int.Parse(number);
int count1=0, del = numberInt;

if (numberInt < 100)
{
    Console.WriteLine($"Вы ввели число меньше 100, число {numberInt} не подходит под условие,третьей цифры нет.");
    return;
}
while (del > 0)
{
    del=del/10;
    count1++;
}

int[] array = new int[count1];
int index = array.Length - 1;
    while (index >= 0)
        {
            array[index] = numberInt%10;
            numberInt = numberInt/10;
            index--;
        }



Console.WriteLine($"Третья цифра в числе это {array[2]}");
