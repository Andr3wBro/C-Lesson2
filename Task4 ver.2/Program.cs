Console.Write("Введите дату => ");
string date = Console.ReadLine();
int dateint = int.Parse(date);
string answer = "0";
if (dateint > 31)
{
    Console.WriteLine("Такого дня недели не существует");
}
else
{
    dateint = dateint % 7;
    if (dateint == 1)
    {
        answer = "Понедельник, рабочий день.";
    }
    if (dateint == 2)
    {
        answer = "Вторник, рабочий день.";
    }
    if (dateint == 3)
    {
        answer = "Среда, рабочий день.";
    }
    if (dateint == 4)
    {
        answer = "Четверг, рабочий день.";
    }
    if (dateint == 5)
    {
        answer = "Пятница, рабочий день.";
    }
    if (dateint == 6)
    {
        answer = "Суббота, ура выходной !";
    }
    if (dateint == 0)
    {
        answer = "Воскресенье, ура выходной !";
    }
}
Console.WriteLine(answer);