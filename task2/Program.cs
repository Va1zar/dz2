//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число = ");
int A = int.Parse(Console.ReadLine()!);

if ( A > 99 )
{
    int result = A / 100 % 10;
    Console.WriteLine("Третья цифра числа = " + result );
}
else
{
    Console.WriteLine("Третьей цифры нет " );
}