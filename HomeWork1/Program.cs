// Задача 1: Напишите цикл, который принимает на вход два числа (A и B)
//  и возводит число A в натуральную степень B (и в нулевую степень).
//   Использовать свои функции, не использовать Math.Pow
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Stepen(int chislo, int step)
{
    int result = 1;
    for (int i = 0; i < step; i++)
    {
        result = result * chislo;
    }
    return result;
}

int A = Prompt("Введите число A : ");
int B = Prompt("Введите число B : ");
int result = Stepen(A, B);
System.Console.WriteLine($"Число {A} в степени {B} равняется : {result}");