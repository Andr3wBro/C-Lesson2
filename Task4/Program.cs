// Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным. Делал как на семинаре исходя что в месяце 31 день и забиваем дату.
Console.Write("Введите дату => ");
string date = Console.ReadLine();
int dateint = int.Parse(date);
string answer = "0";
if (dateint > 31)
{
    Console.WriteLine("Такого дня недели не существует");
    return;
}

dateint = dateint % 7;
if (dateint == 6 || dateint == 0)
    {
        answer = "Да это выходные ! Ура !";
    }
else
    {
        answer = "Идем на работу";
    }

Console.WriteLine(answer);