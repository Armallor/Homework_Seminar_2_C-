// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
Console.WriteLine("Введите число");
string A = Console.ReadLine()!;
int B = A.Length;
if (B < 3) Console.WriteLine("Число состоит менее чем из 3-х цифр");
else Console.WriteLine($"третья цифра числа равна {A[2]}");