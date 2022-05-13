/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет*/
Console.WriteLine("Введите цифру, обозначающую день недели");
int digit = Convert.ToInt32(Console.ReadLine());
if (digit == 6 || digit == 7)
    Console.WriteLine("Выходной день");
else if (digit == 0 || digit > 7)
    Console.WriteLine("Ошибка ввода, пожалуйста повторите ввод");
else
    Console.WriteLine("Будний день");
