// Задача 2: Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в числе. 
// Функция должна на вход принимать число, а выдавать сумму его цифр
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Prompt(string message)
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SumChifr(int chislo)
{
    int sum = 0;
    while (chislo > 0)
    {
        sum = sum + (chislo % 10);
        chislo = chislo / 10;
    }
    return sum;
}

int msg = Prompt("Введите число: ");
int sum = SumChifr(msg);
System.Console.WriteLine($"Суммой цифр веденного числа {msg} будет:  {sum}");