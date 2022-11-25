//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом
Console.Write("Введите 5-значное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string numberText = number.ToString();

if(numberText[0] == numberText[4] && numberText[1] == numberText[3])
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}
