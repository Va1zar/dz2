//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифрой день недели = ");
int A = int.Parse(Console.ReadLine()!);
int Monday = 1;
int Tuesday = 2;
int Wednesday = 3;
int Thursday = 4;
int Friday = 5;
int Saturday = 6;
int Sunday = 7;
if ( A <= 5 )
{
    Console.WriteLine("День не является выходным =( ");
}
else if ( A >= 6 & A <= 7)
{
    Console.WriteLine("День является выходным =) ");
}
else
{
    Console.WriteLine("Введите правильное число дня недели пожалуйста ;) ");
}