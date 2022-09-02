/* Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> "2, 4"
M = 4; N = 8 -> "4, 6, 8" */

int Prompt(string message)
{
    System.Console.Write(message);                    // Вывести сообщение
    int result = Convert.ToInt32(Console.ReadLine()); // Считывает значение
    return result;                                    // Возвращает результат
}

void EvenNaturalNumbers(int numM, int numN, int trend)
{
    System.Console.WriteLine(numM);
    if(numM == numN)
    {
        return;
    }
    EvenNaturalNumbers(numM + trend, numN, trend);
}

void Main()
{
    int numM = Prompt("Введите значение М ");
    int numN = Prompt("Введите значение N ");
    int trend = 0;          // Направление счета, шаг
    if (numM < 2 && numN < 2)   
    {
        System.Console.WriteLine("Решения задачи не существует");
        return;
    }
    if (numM < 2)       // Если вне диапазона, приводим к 2
    {
        numM = 2;
    }
    if (numN < 2)       // Если вне диапазона, приводим к 2
    {
        numN = 2;
    }
    if (numM < numN)        // Выясняем направление счета
    {
        if (numM % 2 > 0)
        {
            numM = numM + 1;
        }
        if (numN % 2 > 0)
        {
            numN = numN - 1;
        }
        trend = 2;
    }
    else
    {
        if (numM % 2 > 0)
        {
            numM = numM - 1;
        }
        if (numN % 2 > 0)
        {
            numN = numN + 1;
        }
        trend = -2;
    }
    EvenNaturalNumbers(numM, numN, trend);
}

Main();