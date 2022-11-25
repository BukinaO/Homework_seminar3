//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int []numbers = new int [5];
if(numbers[0] == numbers[4] && numbers[1] == numbers [3])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
