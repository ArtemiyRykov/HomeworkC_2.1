//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.WriteLine("Введите число: ");

string number = Convert.ToString(Console.ReadLine());
int index = 2;

if(index < number.Length)
{
    Console.WriteLine($"Третья цифра в числе: {number[2]}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}