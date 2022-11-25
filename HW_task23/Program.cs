// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while(i<= number)
{
    Console.WriteLine(i*i*i + " ");
    i++;
}
